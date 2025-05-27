using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Intro_C__backend.Models
{
    public class Paises
    {
        public string Nombre { get; set; }
        public int NumHabitantes { get; set; }
        public string FK_Sofas { get; set; }
        public string NombreSofas { get; set; }
        public int NumSofas { get; set; }

        public string ColorSofas { get; set; }

        public Paises( string Nombre, int NumHabitantes, string Fk_Sofas, string NombreSofas, string ColorSofas, int Numsofas) 
        { 
            this.Nombre = Nombre;
            this.NumHabitantes = NumHabitantes;
            this.FK_Sofas = Fk_Sofas;
            this.NombreSofas = NombreSofas;
            this.ColorSofas = ColorSofas;
            this.NumSofas = Numsofas;

        }
        public void VendenSofas(int vendido)
        {
            //Console.WriteLine($"Nombre: {Nombre}, Habitantes: {NumHabitantes}");
            Console.WriteLine($"\nSofas vendidos: {vendido}\n");
            NumSofas -= vendido;

        }
    }
}
