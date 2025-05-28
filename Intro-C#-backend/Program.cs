using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using Intro_C__backend.Models;

namespace Intro_C__backend{
    class Program
    {

        static void Main(string[] args)
        {
            // Iniciar la aplicación y mostrar los sofas de la base de datos
            SofasDB sofasDB = new SofasDB();
            // Obtener los sofas con el código "00002"
            var sofas = sofasDB.Get("00002");

            Console.WriteLine("Esta va por ti Profesor Juan Ramon Alemany\n");

            // Mostrar los sofas obtenidos
            foreach (var item in sofas)
            {
                Console.WriteLine($"{item.Codigo}, {item.NombreSofas}, {item.ColorSofas}, {item.CodigoP},{item.Nombre},{item.NumHabitantes}");
            }

        }
    }

   
}   