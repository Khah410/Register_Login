using Google.Cloud.Firestore;
using Register_Login.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Register_Login.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        private string verificationCode;
        private string userMail;
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void SendEmail(string email, string code)
        {
            string fromEmail = "your-email@gmail.com";
            string formPassword = "your-password";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromEmail);
            message.To.Add(new MailAddress(email));
            message.Subject = "Confirmation code for password reset.";
            message.Body = $"Your confirmation code is : {code}";

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new NetworkCredential(fromEmail, formPassword);
            client.EnableSsl = true;

            client.Send(message);
            MessageBox.Show("Email sent successfully");

        }

        private void ResetPassword_btn_Click(object sender, EventArgs e)
        {
            string code = CodeBox.Text.Trim();
            if(code == verificationCode)
            {
                ResetPasswordForm form = new ResetPasswordForm(userMail);
                form.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Incorrect verification code.");
            }
        }

        private void SendCode_btn_Click(object sender, EventArgs e)
        {
            userMail = EmailBox.Text.Trim();
            var db = FirestoreDb.Create("your-project-id");
            //var db = FireStoreHelper.Database;
            Query query = db.Collection("UserData").WhereEqualTo("Email", userMail);
            QuerySnapshot snapshot = query.GetSnapshotAsync().Result;

            if (snapshot.Documents.Count > 0)
            {
                verificationCode = new Random().Next(100000, 999999).ToString();

                SendEmail(userMail, verificationCode);

                MessageBox.Show("The confirmation codes has been sent tp your Email. Please check your Email");
            }

            else
            {
                MessageBox.Show("Email does not exist.");
            }

        }
    }
}
