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

            //--Mostrar mensaje de bienvenida
            //--Iniciar la aplicación 
            SofasDB sofasDB = new SofasDB();

            //--Insertamos un nuevo sofa
            /*
            Sofases newsofa = new Sofases("01","",0,"00007","Sofa C# Style","Azul");
            sofasDB.Add(newsofa);
            */


            //--Editar un sofa existente
            /*
            Sofases editsofa = new Sofases("01", "", 0, "00007", "Sofa NODE.JS Style", "Azul");
            sofasDB.Edit(editsofa);
             */

            //--Eliminar un sofa existente
            Sofases delsofa = new Sofases("01", "", 0, "00007", "Sofa NODE.JS Style", "Azul");
            sofasDB.Delete(delsofa);

            // Obtener los sofas con el código "00002"
            var sofasinfo = sofasDB.Get();

            Console.WriteLine("Esta va por ti Profesor Juan Ramon Alemany\n");

            // Mostrar los sofas obtenidos
            foreach (var item in sofasinfo)
            {
                Console.WriteLine($"{item.Codigo}, {item.NombreSofas}, {item.ColorSofas}, {item.CodigoP},{item.Nombre},{item.NumHabitantes}");
            }

        }
    }

   
}   