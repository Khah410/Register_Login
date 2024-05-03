using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register_Login.Classes
{
    internal static class FireStoreHelper
    {
        static string fireconfig = @"
{
  ""type"": ""service_account"",
  ""project_id"": ""register-login-60140"",
  ""private_key_id"": ""6132fd6b2cb2f302b10e8ae0a34d66032a6da757"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCwx/ld9lOXRO4D\n8Mw6Es14oHjGlj6JPVYv4EYXEIfFg9jglSlDM09ybM0O1kqwUdzkZl4oB9jnpkeo\n8CqKAACBjzBPIEQxwkWczOO12FTjzH88OcBTTkRqagZU6XlTFQK6NIJJeRhmX98G\nVsB6VGTizfMqN+zglrCc2gCMdgBtAaYaS+lqRo2IUvkXzzlCSRLhhSbi0Pdocmkn\nf0pwfMG+9cto7aQPDVlKbshwMRPRnxH0lf7HcrpXwqUhZPo5Fvw2bOGhqCcqimBw\nTO5QzatuVflAZCTVbytmwGX0EpYV70lMp2WD8iFM62+rX9kuUzAR+b4MIL6kcYiR\n+CjZ0yuvAgMBAAECggEABY+mCBO+u92NmmW0CCNdbX9fZmmXsQdlbuhFBVRL3a7a\nDKcm3xNif6OkbJtHATaFeyx2FM650UlwK82NLr4Hap4/mANYevyHL14S9AeRy4Bz\nKH+kTbYCq2O+UNGl/HwrXN3F3FLW0ikPND0PHSoK6iLAS73F7V53CbS0gCRjBFPv\nLTSH1PHO/wGCOwGOWxB6+lfNhgdaClzQTxZ+dyCiMPkBM6weouicI6qurIJSWe/D\nTUzBdW5yU4JsjMlnsWPRL624HgK0dbSt7BGViVD6gQUvz9B4b1FpwdEYgmjWVM2G\nAx8rNAowitzrETpHaOWmKU/m3hgl5o8QEkeG7aroNQKBgQDkFkbB7XcHCC3GIJDR\n5KaRGYBosM/lecVDMR3Vso5gGJgT4lJAiOW00llYCpPpmBnMk/5eLc8x/kDK0UI0\nR3AiL8EoR0f/lRUwAWaOr3GoO3+rtw4d2OG1teuZ/m+4boUT20Me3UQUZsRJjisK\nIXFeTjmpL/GsuBEzgqupFyLpkwKBgQDGalbkDlCcQ0F0W9LaD1QmDqoj1X5BF2WD\nx0FFWtsIcfMelcKvxYFwp5fXHgdisPXtn6o4nh7rZpFJhONk9r3ZgxzRTr5BM3xi\nWvgpXIV/6Z9XfywLLnQVa12u8BpaLpGDwp0dmpPUsggmWmp803izKS7LcqTW9bz3\nfRBxz60W9QKBgQC1AXyrn7DK8tGonuVuvH73PX6rFk4V9Tn3pb3gffABEON3PC88\nKafphNkERni1c1BeCsBdqwr3yKdQjRp19I9ngfBO76qSiJQk4aeq6k5PTNB3zDC2\nvQv6MWHEdqfgfEy9wk6U6tGBQ0DYgqtjQcD/LyMRQgwPno+ACl4CNWsuYwKBgD1V\ntASNlEep1rsEg5qa8HVPRTMMlRnEBMKGvtuUqW7j4rbKrsMtN8U+WYbLJpdQgsVw\n/OrBnmdAbpsedDjKuYdaq3bcc52uL74rxtjqW+5dpr8iddgDBSl15iDk4hCMorjr\nWSxEk3xFiJVqj86EhKRFj8yeZOx6TG7o/0NfYm9dAoGAbqNBMVyJWXATBbg8T0lD\nLBWvCD/o808Qoe1whCIDszmZvJiGNV44e0Ndubef7eN/7L9vu2N+cyhJ6EJcQI8N\nBPISd3R6xrLK2swu6P69FJ8t6PcPlNFTVHtm0rGYf2KtR1dvJJl/ed3ZWbUQULRx\nCJrt4BirIOvLu0xRWtp+eyk=\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-adminsdk-x8y47@register-login-60140.iam.gserviceaccount.com"",
  ""client_id"": ""104148355539172398095"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-x8y47%40register-login-60140.iam.gserviceaccount.com"",
  ""universe_domain"": ""googleapis.com""
}

";

        static string filepath = "";
        public static FirestoreDb Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            FirestoreDb db = FirestoreDb.Create("your-project-id");
            Database = FirestoreDb.Create("register-login-60140");
            File.Delete(filepath);
        }
    }
}
