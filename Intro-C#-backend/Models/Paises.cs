using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Intro_C__backend.Models
{
    public class Paises
    {
        public string CodigoPais { get; set; }
        public string Nombre { get; set; }
        public int NumHabitantes { get; set; }
        public string FK_Sofas { get; set; }


        public Paises( string CodigoPais,string Nombre, int NumHabitantes, string Fk_Sofas, string NombreSofas, string ColorSofas, int Numsofas) 
        { 
            this.CodigoPais = CodigoPais;
            this.Nombre = Nombre;
            this.NumHabitantes = NumHabitantes;
            this.FK_Sofas = Fk_Sofas;
            

        }
 
    }
}
