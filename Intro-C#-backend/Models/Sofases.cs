using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intro_C__backend.Models;

namespace Intro_C__backend.Models
{
    internal class Sofases : Paises
    {
        
        

        
        //public Sofases() : base("España", 10000, "001", "Confort",10) // Llamada al constructor base con valores por defecto
        //{

        //}
        public Sofases(string Nombre, int NumHabitantes,string FK_Sofa, string NombreSofa, string ColorSofas ,int NumSofas) 
               :base( Nombre, NumHabitantes, FK_Sofa, NombreSofa, ColorSofas, NumSofas)
            { 

            }
        
    }
}
