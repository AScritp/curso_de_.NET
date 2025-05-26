using System;
using System.ComponentModel;
using Intro_C__backend.Models;

namespace Intro_C__backend{
    class Program
    {

        static void Main(string[] args)
        {
            int vendido = 2;

            Sofases sofases = new ("001","Confort","Negro",10);
            
            Console.WriteLine($"Inicio de temporada:\n Nombre del País: {sofases.Nombre}, Habitantes: {sofases.NumHabitantes}\n Inventario de sofas:\n " +
                $"Codigo de sofa: {sofases.FK_Sofas}\n Nombre de Sofa: {sofases.NombreSofas}\n Color del sofa: {sofases.ColorSofas}\n Existencias disponibles: {sofases.NumSofas}");
            sofases.VendenSofas(vendido);

            Console.WriteLine($"Fin de temporada:\n Nombre del País: {sofases.Nombre}, Habitantes: {sofases.NumHabitantes}\n Inventario de sofas:\n " +
                $"Codigo de sofa: {sofases.FK_Sofas}\n Nombre de Sofa: {sofases.NombreSofas}\n Color del sofa: {sofases.ColorSofas}\n Existencias disponibles: {sofases.NumSofas}");
        }
    }

   
}