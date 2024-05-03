using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register_Login.Classes
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public string UserName { get; set; }
        [FirestoreProperty]
        public string PassWord { get; set; }
        [FirestoreProperty]
        public string Gender { get; set; }
        [FirestoreProperty]
        public int Code { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
    }
}
