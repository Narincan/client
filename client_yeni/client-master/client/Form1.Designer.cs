namespace client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorButton = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Disconnect_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(67, 50);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(88, 20);
            this.textBox_ip.TabIndex = 2;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(67, 79);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(88, 20);
            this.textBox_port.TabIndex = 3;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(67, 112);
            this.button_connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(70, 22);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(244, 52);
            this.logs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(192, 261);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            // 
            // textBox_message
            // 
            this.textBox_message.Enabled = false;
            this.textBox_message.Location = new System.Drawing.Point(90, 273);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(98, 20);
            this.textBox_message.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(90, 299);
            this.button_send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(98, 26);
            this.button_send.TabIndex = 8;
            this.button_send.Text = "Submit";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // RockButton
            // 
            this.RockButton.Location = new System.Drawing.Point(67, 148);
            this.RockButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(70, 26);
            this.RockButton.TabIndex = 9;
            this.RockButton.Text = "ROCK";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Location = new System.Drawing.Point(67, 178);
            this.PaperButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(70, 27);
            this.PaperButton.TabIndex = 10;
            this.PaperButton.Text = "PAPER";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorButton
            // 
            this.ScissorButton.Location = new System.Drawing.Point(67, 209);
            this.ScissorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScissorButton.Name = "ScissorButton";
            this.ScissorButton.Size = new System.Drawing.Size(70, 27);
            this.ScissorButton.TabIndex = 11;
            this.ScissorButton.Text = "SCISSORS";
            this.ScissorButton.UseVisualStyleBackColor = true;
            this.ScissorButton.Click += new System.EventHandler(this.ScissorButton_Click);
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(486, 82);
            this.userListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(104, 212);
            this.userListBox.TabIndex = 12;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "User List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Log";
            // 
            // Disconnect_Button
            // 
            this.Disconnect_Button.Location = new System.Drawing.Point(484, 299);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(106, 47);
            this.Disconnect_Button.TabIndex = 15;
            this.Disconnect_Button.Text = "Disconnect";
            this.Disconnect_Button.UseVisualStyleBackColor = true;
            this.Disconnect_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 358);
            this.Controls.Add(this.Disconnect_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.ScissorButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorButton;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Disconnect_Button;
    }
}

