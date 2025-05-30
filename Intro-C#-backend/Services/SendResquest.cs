using Intro_C__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Intro_C__backend.Services
{
    //"Generic" se usan para indicar a las clases el tipo del objeto con el van a trabajar

    //El "<T>" indica que va recibir una clase que difinirá el objeto

    //Para controlar los datos que entran
    internal class SendResquest<T> where T : ISendRequest //<-- Con esto le indicamos que solo permita objetos que tengan esta interfaz
    {
        private HttpClient _client = new HttpClient();
        public async Task<T> Send(T model) 
        {
            string url = "http://localhost:3000/api/disenadores/";
            var data=JsonSerializer.Serialize<T>(model);

            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpresponse = await _client.PostAsync(url, content);
            if (httpresponse.IsSuccessStatusCode) 
            { 
                var result= await httpresponse.Content.ReadAsStringAsync();

                var postresult =JsonSerializer.Deserialize<T>(result);
                return postresult;
            
            }
            return default(T);
        }
        public async Task<T> Edit(T model,string id)
        {
            string url = $"http://localhost:3000/api/disenadores/{id}";
            var data = JsonSerializer.Serialize<T>(model);

            HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var httpresponse = await _client.PutAsync(url, content);
            if (httpresponse.IsSuccessStatusCode)
            {
                var result = await httpresponse.Content.ReadAsStringAsync();

                var putresult = JsonSerializer.Deserialize<T>(result);
                return putresult;

            }
            return default(T);
        }
        public async Task<T> Delete(string id)
        {
            string url = $"http://localhost:3000/api/disenadores/{id}";
           

            var httpresponse = await _client.DeleteAsync(url);
            if (httpresponse.IsSuccessStatusCode)
            {
                var result = await httpresponse.Content.ReadAsStringAsync();

                var delresult = JsonSerializer.Deserialize<T>(result);
                return delresult;

            }
            return default(T);
        }
    }
}
