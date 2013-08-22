using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace ChatClient
{
	public partial class Form1 : Form
	{

		Socket m_sckt;
		EndPoint m_endPointLocal, m_endPointRemote;

		public Form1()
		{
			InitializeComponent();

			m_sckt = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp); 
			m_sckt.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
			YourIP.Text = GetLocalIP();
			YourIP.Enabled = false;
			TheirIP.Text = GetLocalIP();
		}

		private string GetLocalIP()
		{
			IPHostEntry host;
			string localIP = "";
			host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (IPAddress ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					localIP = ip.ToString();
				}
			}
			return localIP;
		}

		private void MessageCallBack(IAsyncResult aSyncResult)
		{
			try
			{
				int size = m_sckt.EndReceiveFrom(aSyncResult, ref m_endPointRemote);
				if(size > 0)
				{
					byte[] receivedData = new byte[1464];

					receivedData = (byte[])aSyncResult.AsyncState;

					ASCIIEncoding eEncoding = new ASCIIEncoding();
					string receivedMessage = eEncoding.GetString(receivedData);

					MessagesSentReceived.Items.Add("Friend: " + receivedMessage);
					MessagesSentReceived.SelectedIndex += 1;
				}

				byte[] buffer = new byte [1500];
				m_sckt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref m_endPointRemote, new AsyncCallback(MessageCallBack), buffer);

			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				m_endPointLocal = new IPEndPoint(IPAddress.Parse(YourIP.Text), Convert.ToInt32(YourPort.Text));
				m_sckt.Bind(m_endPointLocal);

				m_endPointRemote = new IPEndPoint(IPAddress.Parse(TheirIP.Text), Convert.ToInt32(TheirPort.Text));
				m_sckt.Connect(m_endPointRemote);

				byte[] buffer = new byte[1500];
				m_sckt.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref m_endPointRemote, new AsyncCallback(MessageCallBack), buffer);

				ConnectButton.Text = "Connected";
				ConnectButton.Enabled = false;
				SendButton.Enabled = true;
				TypingBox.Focus();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				ASCIIEncoding enc = new ASCIIEncoding();
				byte[] msg = new byte[1500];
				msg = enc.GetBytes(TypingBox.Text);

				m_sckt.Send(msg);
				MessagesSentReceived.Items.Add("You: " + TypingBox.Text);
				MessagesSentReceived.SelectedIndex += 1;
				TypingBox.Clear();
				TypingBox.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void TypingBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				try
				{
					ASCIIEncoding enc = new ASCIIEncoding();
					byte[] msg = new byte[1500];
					msg = enc.GetBytes(TypingBox.Text);

					m_sckt.Send(msg);
					MessagesSentReceived.Items.Add("You: " + TypingBox.Text);
					MessagesSentReceived.SelectedIndex += 1;
					TypingBox.Clear();
					TypingBox.Focus();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
	}
}
