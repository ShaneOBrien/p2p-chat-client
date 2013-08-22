namespace ChatClient
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Client1 = new System.Windows.Forms.GroupBox();
			this.CL1Port = new System.Windows.Forms.Label();
			this.CL1IPAddress = new System.Windows.Forms.Label();
			this.YourPort = new System.Windows.Forms.TextBox();
			this.YourIP = new System.Windows.Forms.TextBox();
			this.MessagesSentReceived = new System.Windows.Forms.ListBox();
			this.ConnectButton = new System.Windows.Forms.Button();
			this.TypingBox = new System.Windows.Forms.TextBox();
			this.SendButton = new System.Windows.Forms.Button();
			this.CL2Port = new System.Windows.Forms.Label();
			this.CL2IPAddress = new System.Windows.Forms.Label();
			this.TheirIP = new System.Windows.Forms.TextBox();
			this.Client2 = new System.Windows.Forms.GroupBox();
			this.TheirPort = new System.Windows.Forms.TextBox();
			this.Client1.SuspendLayout();
			this.Client2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Client1
			// 
			this.Client1.Controls.Add(this.CL1Port);
			this.Client1.Controls.Add(this.CL1IPAddress);
			this.Client1.Controls.Add(this.YourPort);
			this.Client1.Controls.Add(this.YourIP);
			this.Client1.Location = new System.Drawing.Point(12, 11);
			this.Client1.Name = "Client1";
			this.Client1.Size = new System.Drawing.Size(200, 100);
			this.Client1.TabIndex = 0;
			this.Client1.TabStop = false;
			this.Client1.Text = "Client 1";
			this.Client1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// CL1Port
			// 
			this.CL1Port.AutoSize = true;
			this.CL1Port.Location = new System.Drawing.Point(6, 57);
			this.CL1Port.Name = "CL1Port";
			this.CL1Port.Size = new System.Drawing.Size(69, 13);
			this.CL1Port.TabIndex = 3;
			this.CL1Port.Text = "Port Number:";
			// 
			// CL1IPAddress
			// 
			this.CL1IPAddress.AutoSize = true;
			this.CL1IPAddress.Location = new System.Drawing.Point(6, 28);
			this.CL1IPAddress.Name = "CL1IPAddress";
			this.CL1IPAddress.Size = new System.Drawing.Size(61, 13);
			this.CL1IPAddress.TabIndex = 2;
			this.CL1IPAddress.Text = "IP Address:";
			// 
			// YourPort
			// 
			this.YourPort.Location = new System.Drawing.Point(81, 53);
			this.YourPort.Name = "YourPort";
			this.YourPort.Size = new System.Drawing.Size(113, 20);
			this.YourPort.TabIndex = 1;
			// 
			// YourIP
			// 
			this.YourIP.Location = new System.Drawing.Point(81, 24);
			this.YourIP.Name = "YourIP";
			this.YourIP.Size = new System.Drawing.Size(113, 20);
			this.YourIP.TabIndex = 0;
			this.YourIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// MessagesSentReceived
			// 
			this.MessagesSentReceived.Cursor = System.Windows.Forms.Cursors.No;
			this.MessagesSentReceived.Enabled = false;
			this.MessagesSentReceived.FormattingEnabled = true;
			this.MessagesSentReceived.Location = new System.Drawing.Point(12, 119);
			this.MessagesSentReceived.Name = "MessagesSentReceived";
			this.MessagesSentReceived.Size = new System.Drawing.Size(406, 108);
			this.MessagesSentReceived.TabIndex = 2;
			// 
			// ConnectButton
			// 
			this.ConnectButton.Location = new System.Drawing.Point(425, 50);
			this.ConnectButton.Name = "ConnectButton";
			this.ConnectButton.Size = new System.Drawing.Size(75, 23);
			this.ConnectButton.TabIndex = 3;
			this.ConnectButton.Text = "Connect";
			this.ConnectButton.UseVisualStyleBackColor = true;
			this.ConnectButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// TypingBox
			// 
			this.TypingBox.AcceptsReturn = true;
			this.TypingBox.Location = new System.Drawing.Point(12, 232);
			this.TypingBox.Name = "TypingBox";
			this.TypingBox.Size = new System.Drawing.Size(406, 20);
			this.TypingBox.TabIndex = 4;
			this.TypingBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TypingBox_KeyDown);
			// 
			// SendButton
			// 
			this.SendButton.Enabled = false;
			this.SendButton.Location = new System.Drawing.Point(424, 231);
			this.SendButton.Name = "SendButton";
			this.SendButton.Size = new System.Drawing.Size(75, 23);
			this.SendButton.TabIndex = 5;
			this.SendButton.Text = "Send";
			this.SendButton.UseVisualStyleBackColor = true;
			this.SendButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// CL2Port
			// 
			this.CL2Port.AutoSize = true;
			this.CL2Port.Location = new System.Drawing.Point(6, 57);
			this.CL2Port.Name = "CL2Port";
			this.CL2Port.Size = new System.Drawing.Size(69, 13);
			this.CL2Port.TabIndex = 3;
			this.CL2Port.Text = "Port Number:";
			// 
			// CL2IPAddress
			// 
			this.CL2IPAddress.AutoSize = true;
			this.CL2IPAddress.Location = new System.Drawing.Point(6, 28);
			this.CL2IPAddress.Name = "CL2IPAddress";
			this.CL2IPAddress.Size = new System.Drawing.Size(61, 13);
			this.CL2IPAddress.TabIndex = 2;
			this.CL2IPAddress.Text = "IP Address:";
			// 
			// TheirIP
			// 
			this.TheirIP.Location = new System.Drawing.Point(81, 24);
			this.TheirIP.Name = "TheirIP";
			this.TheirIP.Size = new System.Drawing.Size(113, 20);
			this.TheirIP.TabIndex = 0;
			// 
			// Client2
			// 
			this.Client2.Controls.Add(this.CL2Port);
			this.Client2.Controls.Add(this.CL2IPAddress);
			this.Client2.Controls.Add(this.TheirPort);
			this.Client2.Controls.Add(this.TheirIP);
			this.Client2.Location = new System.Drawing.Point(218, 11);
			this.Client2.Name = "Client2";
			this.Client2.Size = new System.Drawing.Size(200, 100);
			this.Client2.TabIndex = 6;
			this.Client2.TabStop = false;
			this.Client2.Text = "Client 2";
			this.Client2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// TheirPort
			// 
			this.TheirPort.Location = new System.Drawing.Point(81, 53);
			this.TheirPort.Name = "TheirPort";
			this.TheirPort.Size = new System.Drawing.Size(113, 20);
			this.TheirPort.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 278);
			this.Controls.Add(this.Client2);
			this.Controls.Add(this.SendButton);
			this.Controls.Add(this.TypingBox);
			this.Controls.Add(this.ConnectButton);
			this.Controls.Add(this.MessagesSentReceived);
			this.Controls.Add(this.Client1);
			this.Name = "Form1";
			this.Text = "P2P Chat";
			this.Client1.ResumeLayout(false);
			this.Client1.PerformLayout();
			this.Client2.ResumeLayout(false);
			this.Client2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox Client1;
		private System.Windows.Forms.Label CL1Port;
		private System.Windows.Forms.Label CL1IPAddress;
		private System.Windows.Forms.TextBox YourPort;
		private System.Windows.Forms.TextBox YourIP;
		private System.Windows.Forms.ListBox MessagesSentReceived;
		private System.Windows.Forms.Button ConnectButton;
		private System.Windows.Forms.TextBox TypingBox;
		private System.Windows.Forms.Button SendButton;
		private System.Windows.Forms.Label CL2Port;
		private System.Windows.Forms.Label CL2IPAddress;
		private System.Windows.Forms.TextBox TheirIP;
		private System.Windows.Forms.GroupBox Client2;
		private System.Windows.Forms.TextBox TheirPort;
	}
}

