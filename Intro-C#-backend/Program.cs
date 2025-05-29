using Intro_C__backend.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json; //--imports para la des/serialización JSON
using System.Text.Json.Serialization;//--imports para la des/serialización JSON
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Intro_C__backend{
    class Program
    {

        static async Task Main(string[] args)
        {
            //Variable con la URL de mi API
            string url = "http://localhost:3000/api/disenadores/";
            //Creo Objeto a partir de la clase HttpClient
            var client = new HttpClient();  
            //Metodo constructor de objeto disenador de la Clase Disenadores
            Disenadores disenador = new Disenadores
            {
                Name = "Sergi",
                Lastname = "Romero",
                Description = "Profesor",
                Picture = "https://example.com/picture.jpg"
            };

            string textjson = JsonSerializer.Serialize<Disenadores>(disenador);

            //Creo un nuevo objeto que tomara los datos serializados de disenador, luego codificamos el text en UTF-8 y por ultimo le integramos una propieda que tienen los JSON
            // Esto sirve para Insertar(POST) datos nuevos o cambiarlos (PUT)
            HttpContent content = new StringContent(textjson, System.Text.Encoding.UTF8, "application/json");

            //==== Las distitas consulta HTTP (Delete, Put(UPDATE), POST(CREATE))=====
            var HttpResponse = await client.DeleteAsync("http://localhost:3000/api/disenadores/68389738b11487c6f8f7baf0");
            //var HttpResponse = await client.PutAsync("http://localhost:3000/api/disenadores/68389738b11487c6f8f7baf0", content);
            //var HttpResponse = await client.PostAsync(url, content);
            //==== Las distitas consulta HTTP (Delete, Put(UPDATE), POST(CREATE))=====

            //Condicional que si recibe un OK por parte del servidor entonces hace lo siguiente
            if (HttpResponse.IsSuccessStatusCode)
            {
                //variable que usa el GET del HTTP
                var HttpGet = await client.GetAsync(url);

                //variable que toma el contenido de la variable "HttpGet" para luego leerlo
                var read = await HttpGet.Content.ReadAsStringAsync();
                //Deserializamos, hay que tener en cuenta que el JSON es una lista de objetos, por ende usamos el List y le ponemos la clase Disenadores para que las propiedades correspondan
                List<Disenadores> desjsonList = JsonSerializer.Deserialize<List<Disenadores>>(read);

                //Bucle que imprime una seria de varoles por cada linea que recorra del contenido
                foreach (var item in desjsonList)
                {
                    Console.WriteLine($"ID:{item.Id} Name: {item.Name}, LastName: {item.Lastname}, Descripción: {item.Description}, Picture: {item.Picture} ");
                }
            }
        }
    }
}   