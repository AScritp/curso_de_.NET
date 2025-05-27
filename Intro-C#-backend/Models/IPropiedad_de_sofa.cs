using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_C__backend.Models
{
     interface IPropiedad_de_sofa
    {
        public string NombreSofas { get; set; }
        public int NumSofas { get; set; }
        public string ColorSofas { get; set; }

        //--Implementar un metodo que venda sofas (METER METODO EN INTERFACES NO ES UNA PRACTICA HABITUAL)
        public void VendenSofas(int vendido)
        {
            
        }
    }
}
