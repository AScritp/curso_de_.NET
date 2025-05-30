using Intro_C__backend.Models;
using System;
using System.ComponentModel;
using System.Linq; //--Extensión de SQL
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
            // LINQ
        
            /*USOS BÁSICOS
             // Creamos una lista del tipo integer que guarda una colección de numeros
            List<int?> numbers = new List<int?>() { 69, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Creamos una variable num que busca el valor "1", si es True devuelve el valor encontrador
            // y si es False da el valor por defecto de Int("0"), aunque el "?" habilita el null
            var num = numbers.Where(n => n == 1).FirstOrDefault();
            Console.WriteLine(num);

            //Creamos una variable num que ordene
            var shortnum = numbers.OrderBy(d => d);
            Console.WriteLine("Numeros ordenados:");
            foreach (var i in shortnum)
            {
                Console.WriteLine(i);
            }

            //Creamos una que sume
            var total = numbers.Sum(d => d);
            Console.WriteLine($"La suma {total}");

            //Creamos una para sacar el promedio
            var promedio = numbers.Average(d => d);
            Console.WriteLine($"El promedio {promedio}");

             */

            /*USOS AVANZADOS*/

            //lISTA DE OBJETOS DISENADORES
            List<Disenadores> listD = new List<Disenadores>() { 
                new Disenadores(){Id="001", Name="Miguel", Lastname="López", Description="Estudiante" },
                new Disenadores(){Id="002", Name="Juan", Lastname="Alemany", Description="Profesor" },
                new Disenadores(){Id="003", Name="Alex", Lastname="Cascales", Description="Estudiante" },
                new Disenadores(){Id="004", Name="Sergi", Lastname="Romero", Description="Profesor" },

            };

            var shorted = from d in listD
                          orderby d.Id descending
                          where d.Description=="Profesor" && d.Lastname=="Romero"
                          select d;

            foreach (var nose in shorted)
            {
                Console.WriteLine($"ID:{nose.Id}, Nombre: {nose.Name}");
            }
        }

    }
}   