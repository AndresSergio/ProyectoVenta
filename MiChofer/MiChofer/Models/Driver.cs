using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiChofer.Models
{
    class Driver : User
    {

        private string birth_date;

        public string Birth_date
        {
            get { return birth_date; }
            set { birth_date = value; }
        }

        private string ci;

        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }


        public Driver()
        { }

        public Driver(FacebookProfile _fb)
        {
            this.name = _fb.Name;
            this.Image = _fb.Picture.Data.Url;
        }


        public override string GetJson()
 
        {
            JObject jobject = new JObject();
            jobject.Add("id", Id);
            //rellenar los campos
            jobject.Add("name", Name);
            jobject.Add("birth_date", Birth_date);
            jobject.Add("ci", Ci);
            jobject.Add("telephone", Phone);
            jobject.Add("address", Address);
            jobject.Add("city", City);
            jobject.Add("email", Email);
            jobject.Add("password", Password);
            jobject.Add("image", Image);
            jobject.Add("date_created", DateCreated);
            return jobject.ToString();
        }
        public override string GetCreateURL() { return m_baseUrl + "driver/create.php"; }
        public override string GetUpdateURL() { return m_baseUrl + "driver/update.php"; }
        public override string GetReadURL() { return m_baseUrl + "driver/read.php"; }
        public override string GetReadSingleURL(string _id) { return m_baseUrl + "driver/read_single.php?id=" + _id; }
        public override string GetDeleteURL() { return m_baseUrl + "driver/delete.php"; }

        public new static string GetLoginURL(string _email, string _password) { return "michoferapi.edccos.com/api/driver/login.php?email=" + _email + "&password=" + _password; }
    }
}
