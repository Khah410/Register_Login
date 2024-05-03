namespace Register_Login.Forms
{
    partial class ForgotPasswordForm
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
            SendCode_btn = new Button();
            ResetPassword_btn = new Button();
            EmailBox = new TextBox();
            CodeBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // SendCode_btn
            // 
            SendCode_btn.Location = new Point(170, 229);
            SendCode_btn.Name = "SendCode_btn";
            SendCode_btn.Size = new Size(122, 50);
            SendCode_btn.TabIndex = 0;
            SendCode_btn.Text = "SendCode";
            SendCode_btn.UseVisualStyleBackColor = true;
            SendCode_btn.Click += SendCode_btn_Click;
            // 
            // ResetPassword_btn
            // 
            ResetPassword_btn.Location = new Point(346, 229);
            ResetPassword_btn.Name = "ResetPassword_btn";
            ResetPassword_btn.Size = new Size(121, 50);
            ResetPassword_btn.TabIndex = 1;
            ResetPassword_btn.Text = "ResetPassword";
            ResetPassword_btn.UseVisualStyleBackColor = true;
            ResetPassword_btn.Click += ResetPassword_btn_Click;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(245, 40);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(263, 27);
            EmailBox.TabIndex = 2;
            // 
            // CodeBox
            // 
            CodeBox.Location = new Point(245, 119);
            CodeBox.Name = "CodeBox";
            CodeBox.Size = new Size(125, 27);
            CodeBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 47);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 126);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 5;
            label2.Text = "Code";
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CodeBox);
            Controls.Add(EmailBox);
            Controls.Add(ResetPassword_btn);
            Controls.Add(SendCode_btn);
            Name = "ForgotPasswordForm";
            Text = "ForgotPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendCode_btn;
        private Button ResetPassword_btn;
        private TextBox EmailBox;
        private TextBox CodeBox;
        private Label label1;
        private Label label2;
    }
}