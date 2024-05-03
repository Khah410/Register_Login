using Google.Cloud.Firestore;
using Register_Login.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register_Login.Forms
{

    public partial class ResetPasswordForm : Form
    {
        private string userEmail;
        public ResetPasswordForm(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void ResetPassword_btn_Click(object sender, EventArgs e)
        {



            string newpassword = NewPasswordBox.Text.Trim();
            string confirmpassword = ConfirmPasswordBox.Text.Trim();

            if (newpassword == confirmpassword)
            {
                var db = FireStoreHelper.Database;
                Query query = db.Collection("UserData").WhereEqualTo("Email", userEmail);
                QuerySnapshot snapshot = query.GetSnapshotAsync().Result;

                if(snapshot.Documents.Count > 0)
                {
                    DocumentReference docRef = snapshot.Documents[0].Reference;
                    string encryptedPassword = Security.Encrypt(newpassword);

                    docRef.UpdateAsync(new Dictionary<string, object>
                    {
                        { "PassWord", encryptedPassword }
                    });

                    MessageBox.Show("Password has been reset successfully.");
                }

                else
                {
                    MessageBox.Show("Password incorrect.");
                }
            }
        }
    }
}
