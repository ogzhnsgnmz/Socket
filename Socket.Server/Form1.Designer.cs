namespace Socket.Server
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
            lbxLog = new ListBox();
            tbxMessage = new TextBox();
            btnGonder = new Button();
            SuspendLayout();
            // 
            // lbxLog
            // 
            lbxLog.FormattingEnabled = true;
            lbxLog.Location = new Point(12, 12);
            lbxLog.Name = "lbxLog";
            lbxLog.Size = new Size(456, 284);
            lbxLog.TabIndex = 4;
            // 
            // tbxMessage
            // 
            tbxMessage.Location = new Point(12, 302);
            tbxMessage.Name = "tbxMessage";
            tbxMessage.Size = new Size(356, 27);
            tbxMessage.TabIndex = 5;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(374, 302);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(94, 29);
            btnGonder.TabIndex = 6;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 344);
            Controls.Add(btnGonder);
            Controls.Add(tbxMessage);
            Controls.Add(lbxLog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lbxLog;
        private TextBox tbxMessage;
        private Button btnGonder;
    }
}
