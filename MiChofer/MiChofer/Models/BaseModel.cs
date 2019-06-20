using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiChofer.Models
{
    public class BaseModel
    {
        //Private variables
        protected string m_baseUrl;

        //Public members
        public int Id { get; set; }
        public string DateCreated { get; set; }

        public BaseModel()
        {
            m_baseUrl = "michoferapi.edccos.com/api/";
        }

        public virtual string GetJson()
        {
            JObject jobject = new JObject();
            jobject.Add("id", Id);
            jobject.Add("date_created", DateCreated);
            return jobject.ToString();
        }
   

        public virtual string GetCreateURL() { return m_baseUrl; }
        public virtual string GetUpdateURL() { return m_baseUrl; }
        public virtual string GetReadURL() { return m_baseUrl; }
        public virtual string GetReadSingleURL(string _id) { return m_baseUrl; }
        public virtual string GetDeleteURL() { return m_baseUrl; }



    }
}
