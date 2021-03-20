using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilitarios;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;


public  class Peticiones
{
     public async Task<string> LoginAsync(LoginRequest login) {

            string url = "http://localhost:55147/api/Login";
            var HttpClient = new HttpClient();
            var body = JsonConvert.SerializeObject(login);
            HttpContent content = new StringContent(body, System.Text.Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse =  await HttpClient.PostAsync(url, content);
            string usuario = httpResponse.Content.ReadAsStringAsync().ToString();
            return usuario;
    }
}