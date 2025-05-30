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
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int NumHabitantes { get; set; }
        


        public Paises( string Codigo,string Nombre, int NumHabitantes) 
        { 
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.NumHabitantes = NumHabitantes;
            
            

        }
 
    }
}
