using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiChofer.Models
{
    class Company : User
    {

        private string activity;

        public string Activity
        {
            get { return activity; }
            set { activity = value; }
        }

        private string website;

        public string Website
        {
            get { return website; }
            set { website = value; }
        }



        public override string GetJson()
        {
            JObject jobject = new JObject();
            jobject.Add("id", Id);
            //rellenar los campos
            jobject.Add("name",Name);
            jobject.Add("activity", Activity);
            jobject.Add("phone", Phone);
            jobject.Add("website", Website);
            jobject.Add("email", Email);
            jobject.Add("password", Password);
            jobject.Add("image", Image);
            jobject.Add("date_created", DateCreated);
            return jobject.ToString();
        }
        public override string GetCreateURL() { return m_baseUrl + "company/create.php"; }
        public override string GetUpdateURL() { return m_baseUrl + "company/update.php"; }
        public override string GetReadURL() { return m_baseUrl + "company/read.php"; }
        public override string GetReadSingleURL(string _id) { return m_baseUrl + "company/read_single.php?id=" + _id; }
        public override string GetDeleteURL() { return m_baseUrl + "company/delete.php"; }



        public new static string GetLoginURL(string _email, string _password) { return "michoferapi.edccos.com/api/company/login.php?email=" + _email + "&password=" + _password; }
    }
}
