namespace Socket.Client
{
    partial class Form2
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
            button2 = new Button();
            button1 = new Button();
            MesajTextBox = new TextBox();
            PortTextBox = new TextBox();
            IpTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbxLog = new ListBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(350, 22);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Bağlan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(385, 377);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MesajTextBox
            // 
            MesajTextBox.Location = new Point(92, 379);
            MesajTextBox.Name = "MesajTextBox";
            MesajTextBox.Size = new Size(233, 27);
            MesajTextBox.TabIndex = 8;
            // 
            // PortTextBox
            // 
            PortTextBox.Location = new Point(226, 22);
            PortTextBox.Name = "PortTextBox";
            PortTextBox.Size = new Size(99, 27);
            PortTextBox.TabIndex = 7;
            PortTextBox.Text = "12345";
            // 
            // IpTextBox
            // 
            IpTextBox.Location = new Point(92, 22);
            IpTextBox.Name = "IpTextBox";
            IpTextBox.Size = new Size(112, 27);
            IpTextBox.TabIndex = 6;
            IpTextBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 12;
            label1.Text = "Hedef";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 24);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 13;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 384);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 14;
            label3.Text = "Mesaj";
            // 
            // lbxLog
            // 
            lbxLog.FormattingEnabled = true;
            lbxLog.Location = new Point(23, 72);
            lbxLog.Name = "lbxLog";
            lbxLog.Size = new Size(456, 284);
            lbxLog.TabIndex = 16;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 429);
            Controls.Add(lbxLog);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(MesajTextBox);
            Controls.Add(PortTextBox);
            Controls.Add(IpTextBox);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox MesajTextBox;
        private TextBox PortTextBox;
        private TextBox IpTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lbxLog;
    }
}