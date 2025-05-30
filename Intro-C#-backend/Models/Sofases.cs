using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intro_C__backend.Models;

namespace Intro_C__backend.Models
{
    public class Sofases : Paises, IPropiedad_de_sofa
    {
        public string Codigo { get; set; }
        public string NombreSofas { get; set; }
        public int NumSofas { get; set; }
        public string ColorSofas { get; set; }

        public string CodigoP { get; set; }



        //public Sofases() : base("España", 10000, "001", "Confort",10) // Llamada al constructor base con valores por defecto
        //{

        //}
        // Constructor sin parametros para permitir la deserialización desde JSON
        public Sofases() : base(null,null, 0) {
        }
        public Sofases(string CodigoPais,string Nombre, int NumHabitantes,string Codigo, string NombreSofas, string ColorSofas ,int NumSofas=0) 
               :base(Codigo, Nombre, NumHabitantes)
            {
            this.Codigo = Codigo;
            this.NombreSofas = NombreSofas;
            this.ColorSofas = ColorSofas;
            this.NumSofas = NumSofas;
            this.CodigoP = CodigoPais;
        }

        public void VendenSofas(int vendido)
        {
            //Console.WriteLine($"Nombre: {Nombre}, Habitantes: {NumHabitantes}");
            Console.WriteLine($"\nSofas vendidos: {vendido}\n");
            NumSofas -= vendido;

        }
    }
}
