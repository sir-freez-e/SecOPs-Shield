namespace SecOPs_Shield
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip = new ContextMenuStrip(components);
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            scanfile_button = new Button();
            scanurl_button = new Button();
            scan_button = new Button();
            tabPage2 = new TabPage();
            connect_button = new Button();
            comboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "SecOPs Security Suite";
            notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(61, 4);
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 419);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(856, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(143, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngegg;
            pictureBox1.Location = new Point(73, 47);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(34, 183);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 3;
            label1.Text = "SecOPs Security";
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(269, 28);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 363);
            panel1.TabIndex = 4;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 4);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(567, 355);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(scanfile_button);
            tabPage1.Controls.Add(scanurl_button);
            tabPage1.Controls.Add(scan_button);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(559, 322);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Antivirus";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // scanfile_button
            // 
            scanfile_button.Location = new Point(34, 149);
            scanfile_button.Margin = new Padding(3, 4, 3, 4);
            scanfile_button.Name = "scanfile_button";
            scanfile_button.Size = new Size(125, 31);
            scanfile_button.TabIndex = 0;
            scanfile_button.Text = "Submit File";
            scanfile_button.UseVisualStyleBackColor = true;
            scanfile_button.Click += scanfile_button_Click;
            // 
            // scanurl_button
            // 
            scanurl_button.Location = new Point(34, 91);
            scanurl_button.Margin = new Padding(3, 4, 3, 4);
            scanurl_button.Name = "scanurl_button";
            scanurl_button.Size = new Size(125, 31);
            scanurl_button.TabIndex = 0;
            scanurl_button.Text = "Scan Url(s)...";
            scanurl_button.UseVisualStyleBackColor = true;
            scanurl_button.Click += scanurl_button_Click;
            // 
            // scan_button
            // 
            scan_button.Location = new Point(34, 39);
            scan_button.Margin = new Padding(3, 4, 3, 4);
            scan_button.Name = "scan_button";
            scan_button.Size = new Size(125, 31);
            scan_button.TabIndex = 0;
            scan_button.Text = "Scan File(s)...";
            scan_button.UseVisualStyleBackColor = true;
            scan_button.Click += scan_button_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(connect_button);
            tabPage2.Controls.Add(comboBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBoxPassword);
            tabPage2.Controls.Add(textBoxUsername);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(559, 322);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "VPN";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // connect_button
            // 
            connect_button.Location = new Point(401, 28);
            connect_button.Margin = new Padding(3, 4, 3, 4);
            connect_button.Name = "connect_button";
            connect_button.Size = new Size(115, 31);
            connect_button.TabIndex = 4;
            connect_button.Text = "Connect >>";
            connect_button.UseVisualStyleBackColor = true;
            connect_button.Click += connect_button_Click;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "vpn.kalilinx.org", "1.1.1.1", "vpnedu.rf.gd" });
            comboBox.Location = new Point(138, 125);
            comboBox.Margin = new Padding(3, 4, 3, 4);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(233, 28);
            comboBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 125);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 2;
            label4.Text = "Profile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 75);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 33);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(138, 71);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(233, 27);
            textBoxPassword.TabIndex = 0;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(138, 27);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(233, 27);
            textBoxUsername.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(856, 445);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "SecOPs Security Suite";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button connect_button;
        private ComboBox comboBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button scanfile_button;
        private Button scanurl_button;
        private Button scan_button;
    }
}