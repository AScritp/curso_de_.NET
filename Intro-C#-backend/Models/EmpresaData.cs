using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_C__backend.Models
{
    public class EmpresaData
    {
        public string Name { get; set; }

        public List<Paises> pais=new List<Paises>();
        public EmpresaData(string Name) { 
            this.Name = Name;
        }
    }
}
