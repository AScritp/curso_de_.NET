using System;
using System.ComponentModel;
using System.Linq;
using Intro_C__backend.Models;

namespace Intro_C__backend{
    class Program
    {

        static void Main(string[] args)
        {
        

            //--Manera 1 de añandir un elemento a una lista
            List<Sofases> sofas = new List<Sofases>(){new Sofases ("01","España", 47000000, "001", "Max Comfort", "Blanco", 10)};

            //--Manera 2 de añadir un elemento a una lista
            sofas.Add(new Sofases("02","Portugal", 30000000, "003", "Luxury", "White", 5));


            //--Manera 3 de añadir un elemento a una lista
            Sofases happy_days = new("04","Reino Unida", 100000000, "005", "Happy Days", "Rojo", 5);
            sofas.Add(happy_days);

            foreach (var sofa in sofas)
            {
                Console.WriteLine($"CodigoDelPais: {sofa.CodigoPais}, Nombre de País: {sofa.Nombre}, Numero de habitantes: {sofa.NumHabitantes}, Lista de sofas:\n" +
                    $"CodigoID: {sofa.FK_Sofas}\n Nombre del Sofa: {sofa.NombreSofas}\n Color: {sofa.ColorSofas}\n Unidades disp: {sofa.NumSofas}\n");


                sofa.VendenSofas(2);
            }


            //--Del tipo cola.
        }
    }

   
}   