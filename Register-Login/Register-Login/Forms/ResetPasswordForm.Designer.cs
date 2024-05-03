namespace Register_Login.Forms
{
    partial class ResetPasswordForm
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
            ResetPassword_btn = new Button();
            NewPasswordBox = new TextBox();
            ConfirmPasswordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ResetPassword_btn
            // 
            ResetPassword_btn.Location = new Point(590, 294);
            ResetPassword_btn.Name = "ResetPassword_btn";
            ResetPassword_btn.Size = new Size(126, 57);
            ResetPassword_btn.TabIndex = 0;
            ResetPassword_btn.Text = "ResetPassword";
            ResetPassword_btn.UseVisualStyleBackColor = true;
            ResetPassword_btn.Click += ResetPassword_btn_Click;
            // 
            // NewPasswordBox
            // 
            NewPasswordBox.Location = new Point(275, 92);
            NewPasswordBox.Name = "NewPasswordBox";
            NewPasswordBox.Size = new Size(160, 27);
            NewPasswordBox.TabIndex = 1;
            // 
            // ConfirmPasswordBox
            // 
            ConfirmPasswordBox.Location = new Point(275, 177);
            ConfirmPasswordBox.Name = "ConfirmPasswordBox";
            ConfirmPasswordBox.Size = new Size(160, 27);
            ConfirmPasswordBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 99);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "NewPassword";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 184);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 4;
            label2.Text = "ConfirmPassword";
            // 
            // ResetPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ConfirmPasswordBox);
            Controls.Add(NewPasswordBox);
            Controls.Add(ResetPassword_btn);
            Name = "ResetPasswordForm";
            Text = "ResetPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResetPassword_btn;
        private TextBox NewPasswordBox;
        private TextBox ConfirmPasswordBox;
        private Label label1;
        private Label label2;
    }
}