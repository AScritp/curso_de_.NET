using Intro_C__backend.Errors;
using Intro_C__backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_C__backend.Services
{
    public class SearcherDisenadores
    {

        List<Disenadores> disenador = new List<Disenadores>()
        {    new Disenadores(){Id="001", Name="Miguel", Lastname="López", Description="Estudiante" },
             new Disenadores(){Id="002", Name="Juan", Lastname="Alemany", Description="Profesor" },
             new Disenadores(){Id="003", Name="Alex", Lastname="Cascales", Description="Estudiante" }
        };
        public string GetDescriptionByName(string name) { 
        
            var info= (from d in disenador
                      where d.Name == name
                      select d).FirstOrDefault(); 
            //--Excepción general creada por el desarrollador para que se esten atentos
            //throw new FieldAccessException("Nadie pasa de esta linea hasta que implemente un CATCH para mi especifico para mi o generico");

            if (info == null) {

                throw new NotFoundException("No se encuentra el valor que ha especificado. Motivo:\n"+
                    "1. Esta mal escrito\n"+
                    "2. No está registrado\n" +
                    "3. Esta buscando en el campo equivocado\n");
            }

            return info.Description;

        }

    }

    
}
