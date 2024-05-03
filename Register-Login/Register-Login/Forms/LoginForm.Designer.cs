namespace Register_Login.Forms
{
    partial class LoginForm
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
            label2 = new Label();
            label1 = new Label();
            Log_btn = new Button();
            BackToRegister_btn = new Button();
            PassBox = new TextBox();
            UserBox = new TextBox();
            Forgot_btn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 123);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 17;
            label2.Text = "PassWord";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 64);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 16;
            label1.Text = "UserName";
            // 
            // Log_btn
            // 
            Log_btn.Location = new Point(303, 236);
            Log_btn.Name = "Log_btn";
            Log_btn.Size = new Size(114, 51);
            Log_btn.TabIndex = 15;
            Log_btn.Text = "Login ";
            Log_btn.UseVisualStyleBackColor = true;
            Log_btn.Click += Log_btn_Click;
            // 
            // BackToRegister_btn
            // 
            BackToRegister_btn.Location = new Point(131, 236);
            BackToRegister_btn.Name = "BackToRegister_btn";
            BackToRegister_btn.Size = new Size(129, 51);
            BackToRegister_btn.TabIndex = 14;
            BackToRegister_btn.Text = "Back to Register";
            BackToRegister_btn.UseVisualStyleBackColor = true;
            BackToRegister_btn.Click += BackToRegister_btn_Click;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(331, 116);
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '@';
            PassBox.Size = new Size(221, 27);
            PassBox.TabIndex = 12;
            PassBox.UseSystemPasswordChar = true;
            // 
            // UserBox
            // 
            UserBox.Location = new Point(331, 57);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(221, 27);
            UserBox.TabIndex = 11;
            // 
            // Forgot_btn
            // 
            Forgot_btn.Location = new Point(474, 236);
            Forgot_btn.Name = "Forgot_btn";
            Forgot_btn.Size = new Size(148, 51);
            Forgot_btn.TabIndex = 18;
            Forgot_btn.Text = "ForgotPassWord";
            Forgot_btn.UseVisualStyleBackColor = true;
            Forgot_btn.Click += Forgot_btn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Forgot_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Log_btn);
            Controls.Add(BackToRegister_btn);
            Controls.Add(PassBox);
            Controls.Add(UserBox);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button Log_btn;
        private Button BackToRegister_btn;
        private TextBox PassBox;
        private TextBox UserBox;
        private Button Forgot_btn;
    }
}