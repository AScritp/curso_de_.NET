using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json; //--imports para la des/serialización JSON
using System.Text.Json.Serialization;//--imports para la des/serialización JSON
using Intro_C__backend.Models;

namespace Intro_C__backend{
    class Program
    {

        static void Main(string[] args)
        {
            /* Fase de serialización de objetos a JSON
            var sofa = new Sofases("01", "", 0, "00007", "Sofa NODE.JS Style", "Azul");
            //El método Serialize de la clase JsonSerializer convierte un objeto en una cadena JSON.
            string myJson = JsonSerializer.Serialize(sofa);
            //File es una clase estática que nos permite trabajar con ficheros de forma sencilla, aquí hacemos uso del método WriteAllText para escribir el JSON en un fichero.
            File.WriteAllText("objeto.txt",myJson);
             */

            // Fase de deserialización de JSON a objetos
            //El método ReadAllText de la clase File lee el contenido de un fichero y lo devuelve como una cadena de texto.
            string filetJson = File.ReadAllText("objeto.txt");
            //Llegados a este punto, en necesario habilitar un constructor sin parámetros en la clase Sofases para poder deserializar correctamente el objeto desde JSON.
            Sofases sofa = JsonSerializer.Deserialize<Sofases>(filetJson);
        }
    }

   
}   