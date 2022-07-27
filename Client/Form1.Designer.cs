namespace Client
{
    partial class MyChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyChat));
            this.textBox_Nickname = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.listBox_chat = new System.Windows.Forms.ListBox();
            this.textBox_sendMessage = new System.Windows.Forms.TextBox();
            this.button_sendMessage = new System.Windows.Forms.Button();
            this.listBox_nicknames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Nickname
            // 
            this.textBox_Nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Nickname.Location = new System.Drawing.Point(120, 33);
            this.textBox_Nickname.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Nickname.Multiline = true;
            this.textBox_Nickname.Name = "textBox_Nickname";
            this.textBox_Nickname.Size = new System.Drawing.Size(200, 30);
            this.textBox_Nickname.TabIndex = 0;
            // 
            // button_connect
            // 
            this.button_connect.BackColor = System.Drawing.Color.Pink;
            this.button_connect.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_connect.Location = new System.Drawing.Point(330, 32);
            this.button_connect.Margin = new System.Windows.Forms.Padding(2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(100, 30);
            this.button_connect.TabIndex = 1;
            this.button_connect.Text = "Приєднатися";
            this.button_connect.UseVisualStyleBackColor = false;
            this.button_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_chat
            // 
            this.listBox_chat.FormattingEnabled = true;
            this.listBox_chat.HorizontalScrollbar = true;
            this.listBox_chat.Location = new System.Drawing.Point(11, 134);
            this.listBox_chat.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_chat.Name = "listBox_chat";
            this.listBox_chat.Size = new System.Drawing.Size(419, 95);
            this.listBox_chat.TabIndex = 2;
            // 
            // textBox_sendMessage
            // 
            this.textBox_sendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_sendMessage.Location = new System.Drawing.Point(120, 86);
            this.textBox_sendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_sendMessage.Multiline = true;
            this.textBox_sendMessage.Name = "textBox_sendMessage";
            this.textBox_sendMessage.Size = new System.Drawing.Size(200, 30);
            this.textBox_sendMessage.TabIndex = 3;
            // 
            // button_sendMessage
            // 
            this.button_sendMessage.BackColor = System.Drawing.Color.Pink;
            this.button_sendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_sendMessage.Location = new System.Drawing.Point(330, 86);
            this.button_sendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.button_sendMessage.Name = "button_sendMessage";
            this.button_sendMessage.Size = new System.Drawing.Size(100, 30);
            this.button_sendMessage.TabIndex = 4;
            this.button_sendMessage.Text = "Надіслати";
            this.button_sendMessage.UseVisualStyleBackColor = false;
            this.button_sendMessage.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_nicknames
            // 
            this.listBox_nicknames.FormattingEnabled = true;
            this.listBox_nicknames.HorizontalScrollbar = true;
            this.listBox_nicknames.Location = new System.Drawing.Point(11, 34);
            this.listBox_nicknames.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_nicknames.Name = "listBox_nicknames";
            this.listBox_nicknames.Size = new System.Drawing.Size(90, 82);
            this.listBox_nicknames.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Онлайн :";
            // 
            // MyChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(444, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_sendMessage);
            this.Controls.Add(this.button_sendMessage);
            this.Controls.Add(this.textBox_Nickname);
            this.Controls.Add(this.listBox_nicknames);
            this.Controls.Add(this.listBox_chat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(460, 270);
            this.MinimumSize = new System.Drawing.Size(460, 270);
            this.Name = "MyChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyChat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nickname;
        private System.Windows.Forms.Button button_connect;
        public System.Windows.Forms.ListBox listBox_chat;
        private System.Windows.Forms.TextBox textBox_sendMessage;
        private System.Windows.Forms.Button button_sendMessage;
        public System.Windows.Forms.ListBox listBox_nicknames;
        private System.Windows.Forms.Label label1;
    }
}

