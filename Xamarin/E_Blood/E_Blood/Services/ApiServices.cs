using E_Blood.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace E_Blood.Services
{
    public class ApiServices
    {
        internal async Task<bool> RegisterAsync(string email, string password, string confirmPassword)
        {
            var client = new HttpClient();

            var model = new RegisterBindingModel
            {
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword

            };

            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);
            var response=await client.PostAsync("https://localhost:44344/api/Account/Register", content);

            return response.IsSuccessStatusCode;
        }
    }
}
