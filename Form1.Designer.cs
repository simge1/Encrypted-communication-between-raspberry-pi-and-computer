namespace rpi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.listBox_sending = new System.Windows.Forms.ListBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.comboBox_username = new System.Windows.Forms.ComboBox();
            this.lbl_towho = new System.Windows.Forms.Label();
            this.comboBox_towho = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.listbox_messages = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_memberlogin = new System.Windows.Forms.Label();
            this.pictureBox_member = new System.Windows.Forms.PictureBox();
            this.lbl_sentbox = new System.Windows.Forms.Label();
            this.lbl_inbox = new System.Windows.Forms.Label();
            this.lbl_secure = new System.Windows.Forms.Label();
            this.pictureBox_secure = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_member)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_secure)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(569, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Location = new System.Drawing.Point(123, 10);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(20, 17);
            this.lbl_IP.TabIndex = 1;
            this.lbl_IP.Text = "IP";
            this.lbl_IP.Visible = false;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(41, 122);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(75, 17);
            this.lbl_message.TabIndex = 2;
            this.lbl_message.Text = "MESSAGE";
            this.lbl_message.Visible = false;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(322, 10);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(47, 17);
            this.lbl_port.TabIndex = 3;
            this.lbl_port.Text = "PORT";
            this.lbl_port.Visible = false;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(149, 7);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(138, 22);
            this.txt_ip.TabIndex = 4;
            this.txt_ip.Text = "192.168.137.10";
            this.txt_ip.Visible = false;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(375, 7);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(124, 22);
            this.txt_port.TabIndex = 5;
            this.txt_port.Text = "8000";
            this.txt_port.Visible = false;
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(126, 117);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(147, 22);
            this.txt_message.TabIndex = 6;
            this.txt_message.Visible = false;
            // 
            // listBox_sending
            // 
            this.listBox_sending.BackColor = System.Drawing.SystemColors.Window;
            this.listBox_sending.FormattingEnabled = true;
            this.listBox_sending.ItemHeight = 16;
            this.listBox_sending.Location = new System.Drawing.Point(44, 304);
            this.listBox_sending.Name = "listBox_sending";
            this.listBox_sending.Size = new System.Drawing.Size(168, 132);
            this.listBox_sending.TabIndex = 7;
            this.listBox_sending.Visible = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(158, 332);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(88, 17);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "PASSWORD";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(158, 290);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(85, 17);
            this.lbl_username.TabIndex = 10;
            this.lbl_username.Text = "USERNAME";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(201, 381);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(130, 55);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // comboBox_username
            // 
            this.comboBox_username.FormattingEnabled = true;
            this.comboBox_username.Items.AddRange(new object[] {
            "ali",
            "veli",
            "ahmet",
            "hasan"});
            this.comboBox_username.Location = new System.Drawing.Point(266, 283);
            this.comboBox_username.Name = "comboBox_username";
            this.comboBox_username.Size = new System.Drawing.Size(121, 24);
            this.comboBox_username.TabIndex = 12;
            // 
            // lbl_towho
            // 
            this.lbl_towho.AutoSize = true;
            this.lbl_towho.Location = new System.Drawing.Point(41, 184);
            this.lbl_towho.Name = "lbl_towho";
            this.lbl_towho.Size = new System.Drawing.Size(62, 17);
            this.lbl_towho.TabIndex = 13;
            this.lbl_towho.Text = "TOWHO";
            this.lbl_towho.Visible = false;
            // 
            // comboBox_towho
            // 
            this.comboBox_towho.FormattingEnabled = true;
            this.comboBox_towho.Location = new System.Drawing.Point(126, 177);
            this.comboBox_towho.Name = "comboBox_towho";
            this.comboBox_towho.Size = new System.Drawing.Size(147, 24);
            this.comboBox_towho.TabIndex = 14;
            this.comboBox_towho.Visible = false;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(266, 327);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(121, 22);
            this.txt_password.TabIndex = 15;
            // 
            // listbox_messages
            // 
            this.listbox_messages.FormattingEnabled = true;
            this.listbox_messages.ItemHeight = 16;
            this.listbox_messages.Location = new System.Drawing.Point(266, 304);
            this.listbox_messages.Name = "listbox_messages";
            this.listbox_messages.Size = new System.Drawing.Size(259, 132);
            this.listbox_messages.TabIndex = 17;
            this.listbox_messages.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_memberlogin
            // 
            this.lbl_memberlogin.AutoSize = true;
            this.lbl_memberlogin.Location = new System.Drawing.Point(208, 250);
            this.lbl_memberlogin.Name = "lbl_memberlogin";
            this.lbl_memberlogin.Size = new System.Drawing.Size(114, 17);
            this.lbl_memberlogin.TabIndex = 23;
            this.lbl_memberlogin.Text = "MEMBER LOGIN";
            // 
            // pictureBox_member
            // 
            this.pictureBox_member.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_member.Image")));
            this.pictureBox_member.Location = new System.Drawing.Point(161, 76);
            this.pictureBox_member.Name = "pictureBox_member";
            this.pictureBox_member.Size = new System.Drawing.Size(203, 158);
            this.pictureBox_member.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_member.TabIndex = 24;
            this.pictureBox_member.TabStop = false;
            // 
            // lbl_sentbox
            // 
            this.lbl_sentbox.AutoSize = true;
            this.lbl_sentbox.BackColor = System.Drawing.Color.SlateGray;
            this.lbl_sentbox.ForeColor = System.Drawing.Color.Black;
            this.lbl_sentbox.Location = new System.Drawing.Point(41, 274);
            this.lbl_sentbox.Name = "lbl_sentbox";
            this.lbl_sentbox.Size = new System.Drawing.Size(78, 17);
            this.lbl_sentbox.TabIndex = 25;
            this.lbl_sentbox.Text = "SENT BOX";
            this.lbl_sentbox.Visible = false;
            // 
            // lbl_inbox
            // 
            this.lbl_inbox.AutoSize = true;
            this.lbl_inbox.Location = new System.Drawing.Point(263, 274);
            this.lbl_inbox.Name = "lbl_inbox";
            this.lbl_inbox.Size = new System.Drawing.Size(50, 17);
            this.lbl_inbox.TabIndex = 26;
            this.lbl_inbox.Text = "INBOX";
            this.lbl_inbox.Visible = false;
            // 
            // lbl_secure
            // 
            this.lbl_secure.AutoSize = true;
            this.lbl_secure.Location = new System.Drawing.Point(123, 56);
            this.lbl_secure.Name = "lbl_secure";
            this.lbl_secure.Size = new System.Drawing.Size(150, 17);
            this.lbl_secure.TabIndex = 27;
            this.lbl_secure.Text = "SECURE MESSAGING";
            this.lbl_secure.Visible = false;
            // 
            // pictureBox_secure
            // 
            this.pictureBox_secure.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_secure.Image")));
            this.pictureBox_secure.Location = new System.Drawing.Point(360, 56);
            this.pictureBox_secure.Name = "pictureBox_secure";
            this.pictureBox_secure.Size = new System.Drawing.Size(165, 145);
            this.pictureBox_secure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_secure.TabIndex = 28;
            this.pictureBox_secure.TabStop = false;
            this.pictureBox_secure.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(569, 504);
            this.Controls.Add(this.pictureBox_secure);
            this.Controls.Add(this.lbl_secure);
            this.Controls.Add(this.lbl_inbox);
            this.Controls.Add(this.lbl_sentbox);
            this.Controls.Add(this.pictureBox_member);
            this.Controls.Add(this.lbl_memberlogin);
            this.Controls.Add(this.listbox_messages);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.comboBox_towho);
            this.Controls.Add(this.lbl_towho);
            this.Controls.Add(this.comboBox_username);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.listBox_sending);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_member)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_secure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.ListBox listBox_sending;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ComboBox comboBox_username;
        private System.Windows.Forms.Label lbl_towho;
        private System.Windows.Forms.ComboBox comboBox_towho;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button mysql;
        private System.Windows.Forms.ListBox listbox_messages;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_memberlogin;
        private System.Windows.Forms.PictureBox pictureBox_member;
        private System.Windows.Forms.Label lbl_sentbox;
        private System.Windows.Forms.Label lbl_inbox;
        private System.Windows.Forms.Label lbl_secure;
        private System.Windows.Forms.PictureBox pictureBox_secure;
    }
}

