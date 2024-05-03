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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void BackToLogin_btn_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
            Close();
        }


        private void Reg_btn_Click(object sender, EventArgs e)
        {
            var db = FireStoreHelper.Database;

            if (CheckIfUserAlreadyExist())
            {
                MessageBox.Show("User Already Exist");
                return;
            }

            var data = GetWirteData();
            DocumentReference docRef = db.Collection("UserData").Document(data.UserName);
            docRef.SetAsync(data);
            MessageBox.Show("Success");
        }

        private UserData GetWirteData()
        {
            

            string username = UserBox.Text.Trim();
            string password = Security.Encrypt(PassBox.Text);
            string gender = GenderBox.Text.Trim();
            int code = Convert.ToInt32(CodeBox.Text);
            string email = EmailBox.Text.Trim();

            return new UserData()
            {
                UserName = username,
                PassWord = password,
                Gender = gender,
                Code = code,
                Email = email
            };
        }

        private bool CheckIfUserAlreadyExist()
        {
            string username = UserBox.Text.Trim();
           

            var db = FireStoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if (data != null)
            {
                return true;
            }
            return false;

           
        }
     }
}
