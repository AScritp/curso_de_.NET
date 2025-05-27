using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intro_C__backend.Models;

namespace Intro_C__backend.Models
{
    internal class Sofases : Paises, IPropiedad_de_sofa
    {
        public string NombreSofas { get; set; }
        public int NumSofas { get; set; }
        public string ColorSofas { get; set; }



        //public Sofases() : base("España", 10000, "001", "Confort",10) // Llamada al constructor base con valores por defecto
        //{

        //}
        public Sofases(string CodigoPais,string Nombre, int NumHabitantes,string FK_Sofa, string NombreSofas, string ColorSofas ,int NumSofas) 
               :base(CodigoPais, Nombre, NumHabitantes, FK_Sofa, NombreSofas, ColorSofas, NumSofas)
            {
            this.NombreSofas = NombreSofas;
            this.ColorSofas = ColorSofas;
            this.NumSofas = NumSofas;
        }

        public void VendenSofas(int vendido)
        {
            //Console.WriteLine($"Nombre: {Nombre}, Habitantes: {NumHabitantes}");
            Console.WriteLine($"\nSofas vendidos: {vendido}\n");
            NumSofas -= vendido;

        }
    }
}
