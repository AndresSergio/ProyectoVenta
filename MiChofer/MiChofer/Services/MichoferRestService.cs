using MiChofer.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace MiChofer.Services
{
    class MichoferRestService
    {
       
            public static async Task<T> Get<T>(string url)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    var response = await client.GetAsync(url);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var jsonstring = await response.Content.ReadAsStringAsync();
                        return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
                return default(T);
            }

            /// <summary>
            /// Function generica Post
            /// </summary>
            /// <param name="_model"></param>
            /// <returns></returns>
            public static async Task<bool> Post(BaseModel _model)
            {
                HttpClient client = new HttpClient();

                var response = await client.PostAsync(_model.GetCreateURL(), new StringContent(_model.GetJson()));
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }
            public static async Task<bool> Put(BaseModel _model)
            {
                HttpClient client = new HttpClient();

                var response = await client.PutAsync(_model.GetUpdateURL(), new StringContent(_model.GetJson()));
                return response.StatusCode == System.Net.HttpStatusCode.OK;
            }

           

        /// <summary>
        /// Funcion rapida para crear una company
        /// </summary>
        /// <param name="_company"></param>
        /// <returns></returns>
            public static async Task<bool> CreateCompany(Company _company)
            {
                ; return await MichoferRestService.Post(_company);
            }

            public static async Task<bool> UpdateCompany(Company _company)
            {
                ; return await MichoferRestService.Put(_company);
            }

            public static async Task<Company> LoginCompany(string _email, string _password)
            {
                Company company = await Get<Company>(Company.GetLoginURL(_email, _password));
                return company;
            }




        /// <summary>
        /// Funcion rapida para crear una company
        /// </summary>
        /// <param name="_driver"></param>
        /// <returns></returns>
            public static async Task<bool> CreateDriver(Driver _driver)
            {
                ; return await MichoferRestService.Post(_driver);
            }
            public static async Task<bool> UpdateDriver(Driver _driver)
            {
                ; return await MichoferRestService.Put(_driver);
            }
            //public static async Task<bool> DeleteDriver(Driver _driver)
            //{
            //    ; return await MichoferRestService.(_driver);
            //}
            public static async Task<Driver> LoginDriver(string _email, string _password)
                        {

                            Driver driver = await Get<Driver>(Driver.GetLoginURL(_email, _password));
                            return driver;
                        }


    }
    
}
