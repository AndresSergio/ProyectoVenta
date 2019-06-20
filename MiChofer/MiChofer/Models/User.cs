using System;
using System.Collections.Generic;
using System.Text;

namespace MiChofer.Models
{
    public class User : BaseModel
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        protected string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        protected string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        protected string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public virtual string GetLoginURL(string _email, string _password) { return "michoferapi.edccos.com/api/company/login.php?email=" + _email + "&password=" + _password; }
    }
}
