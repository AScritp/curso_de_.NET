using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_C__backend.Models
{
    public class Empresa
    {

        public string Nombre { get; set; }
        public List<Disenadores> disenadores =new List<Disenadores>();
        public List<Sofases> sofases=new List<Sofases>();
        public Empresa(string Nombre) { 
            this.Nombre = Nombre;
        }
    }
}
