using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json; //--imports para la des/serialización JSON
using System.Text.Json.Serialization;//--imports para la des/serialización JSON
using Intro_C__backend.Models;
using System.Threading.Tasks;// importamos una librería para poder usar async/await
using System.Net.Http; // Importamos HttpClient para hacer peticiones HTTP

namespace Intro_C__backend{
    class Program
    {

        static async Task Main(string[] args)

        {
            // Petición HTTP a la PokeAPI para obtener información de un Pokémon
            //Aqui simulamos un evento de Pokémon, como si fuera un juego de Pokémon, para enteder el comportamiento del async/await

            /*Practia/Ejercicio 1 :
              Console.WriteLine("Simulador de eventos Pokemon");
            Console.WriteLine("==================================\n");
            string pkmname = "pikachu"; // Nombre del Pokémon a buscar
            string url = $"https://pokeapi.co/api/v2/pokemon/{pkmname}";
            
            HttpClient client = new();
            
            Console.WriteLine("Entrenador entra a un llervajo, y se encuetra algo");

            var res=client.GetAsync(url);

            
            Console.WriteLine($"Cargando animeación de evento");
            Console.WriteLine($"Cargando animeación sonido del Pokemon");
            Console.WriteLine($"Cargando animeación animación de sprites");

            await res;

            Console.WriteLine($"Entrenador se enfrenta a  un Pokémon: {pkmname} y estos son sus datos: {res}");
             */


            Console.WriteLine("Simulador de eventos Pokemon");
            Console.WriteLine("==================================\n");

            //--creo una variable que almacena el nombre del Pokémon a buscar
            string pkmname = "pikachu"; // Nombre del Pokémon a buscar
            //--Construyo la URL de la API de Pokémon con el nombre del Pokémon
            string url = $"https://pokeapi.co/api/v2/pokemon/{pkmname}";

            //--creo una instancia de HttpClient para realizar la petición HTTP
            HttpClient client = new();


            //--creo una variable que almacena el mensaje de inicio del evento 
            var httpsResponse = await client.GetAsync(url);

            //--Creo un if para comprobar si la respuesta HTTP fue exitosa
            if (httpsResponse.IsSuccessStatusCode) 
            {
                //--Si la respuesta es exitosa, leo el contenido de la respuesta como una cadena de texto
                var content = await httpsResponse.Content.ReadAsStringAsync();
                //--Deserializo el contenido JSON en un objeto de tipo PkmAPI
                PkmAPI desjson = JsonSerializer.Deserialize<PkmAPI>(content);

                Console.WriteLine($"Entrenador se enfrenta a un Pokémon: {pkmname}\n");

                // Imprimir una lista llamada: "habilidades"
                Console.WriteLine("Habilidades:");
                // Recorremos la lista de habilidades del Pokémon y por cada linea imprimimos el nombre de la habilidad y si es oculta o no
                foreach (var ability in desjson.Abilities)
                {
                    // Imprimimos el nombre de la habilidad y si es oculta o no
                    Console.WriteLine($"- {ability.Ability.Name} (hidden: {ability.IsHidden})");
                }

                // Imprimir experiencia base
                Console.WriteLine($"\nExperiencia base: {desjson.BaseExperience}");

                // Imprimir una lista llamada: "formas"
                Console.WriteLine("\nFormas:");
                foreach (var form in desjson.Forms)
                {
                    // Imprimimos cada nombre que aparece en la lista de formas
                    Console.WriteLine($"- {form.Name}");
                }

                // Imprimir una lista llamada: game_indices
                Console.WriteLine("\nÍndice en juegos:");
                foreach (var gameIndex in desjson.GameIndices)
                {
                    // Imprimimos el nombre del juego y el índice del Pokémon en ese juego
                    Console.WriteLine($"- Juego: {gameIndex.Version.Name}, Índice: {gameIndex.Index}");
                }


            }






            }
    }

   
}   