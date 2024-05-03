namespace Register_Login.Forms
{
    partial class RegisterForm
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
            UserBox = new TextBox();
            PassBox = new TextBox();
            CodeBox = new TextBox();
            BackToLogin_btn = new Button();
            Reg_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            GenderBox = new ComboBox();
            EmailBox = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // UserBox
            // 
            UserBox.Location = new Point(249, 35);
            UserBox.Name = "UserBox";
            UserBox.Size = new Size(221, 27);
            UserBox.TabIndex = 0;
            // 
            // PassBox
            // 
            PassBox.Location = new Point(249, 94);
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '*';
            PassBox.Size = new Size(221, 27);
            PassBox.TabIndex = 1;
            PassBox.UseSystemPasswordChar = true;
            // 
            // CodeBox
            // 
            CodeBox.Location = new Point(249, 235);
            CodeBox.Name = "CodeBox";
            CodeBox.Size = new Size(221, 27);
            CodeBox.TabIndex = 3;
            // 
            // BackToLogin_btn
            // 
            BackToLogin_btn.Location = new Point(168, 366);
            BackToLogin_btn.Name = "BackToLogin_btn";
            BackToLogin_btn.Size = new Size(129, 51);
            BackToLogin_btn.TabIndex = 4;
            BackToLogin_btn.Text = "Back to Login";
            BackToLogin_btn.UseVisualStyleBackColor = true;
            BackToLogin_btn.Click += BackToLogin_btn_Click;
            // 
            // Reg_btn
            // 
            Reg_btn.Location = new Point(394, 366);
            Reg_btn.Name = "Reg_btn";
            Reg_btn.Size = new Size(114, 51);
            Reg_btn.TabIndex = 5;
            Reg_btn.Text = "Register User";
            Reg_btn.UseVisualStyleBackColor = true;
            Reg_btn.Click += Reg_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 42);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "PassWord";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 166);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 242);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 9;
            label4.Text = "Code";
            // 
            // GenderBox
            // 
            GenderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenderBox.FormattingEnabled = true;
            GenderBox.Items.AddRange(new object[] { "Male", "Female", "Other" });
            GenderBox.Location = new Point(249, 163);
            GenderBox.Name = "GenderBox";
            GenderBox.Size = new Size(221, 28);
            GenderBox.TabIndex = 10;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(249, 303);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(221, 27);
            EmailBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 310);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(EmailBox);
            Controls.Add(GenderBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Reg_btn);
            Controls.Add(BackToLogin_btn);
            Controls.Add(CodeBox);
            Controls.Add(PassBox);
            Controls.Add(UserBox);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserBox;
        private TextBox PassBox;
        private TextBox CodeBox;
        private Button BackToLogin_btn;
        private Button Reg_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox GenderBox;
        private TextBox EmailBox;
        private Label label5;
    }
}