using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_C__backend.Errors
{
    public class NotFoundException : Exception //<--Hacemos que nuestra clase Excepción personalizada tome "beba" de la clase padre Exception
    {
        //Tambien se pueden crear excepciones gracias a la herencia 
        //Expeción tiene 3 constructores para desempeñar distintas funciones
        public NotFoundException(): base() { } 

        public NotFoundException(string? message) : base(message)//<-- Este constructor son los que suelen mandar el mesaje de Exception
        {
        }

        public NotFoundException(string? message, Exception? inner) : base(message, inner)//<-- Tambien nos podemos encontrar con excepciones, 
                                                                                          //Tiene o puede tener uno o mas mensages
                                                                                          //dibo a que puede albergar excepciones internas, lo que causa recurrencia interna
        {
        }
    }
}
