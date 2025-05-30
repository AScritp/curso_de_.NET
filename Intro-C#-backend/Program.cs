using Intro_C__backend.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json; //--imports para la des/serialización JSON
using System.Text.Json.Serialization;//--imports para la des/serialización JSON
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Intro_C__backend{
    class Program
    {

        static async Task Main(string[] args)
        {
            //"Generic"

            Disenadores disenador = new Disenadores() 
            {
                Name= "Alex",
                Lastname="Cascales",
                Description="Programador FRONTEND",
                Picture="Foto de perfil"
            };

            

            Services.SendResquest<Disenadores> service = new Services.SendResquest<Disenadores>();
            var answer =  await service.Send(disenador);


            //Ahora literalmente podemos crear cualquier objeto y cuyo constructor tenga cualquier propieddad.

            /*
            var sofas = new Sofases() { Codigo = "0001", Nombre = "ssdfasdf" };
            Services.SendResquest<Sofases> service = new Services.SendResquest<Sofases>();
            var answer = await service.Send(sofas);
            */
            /*
                Ya que las fuciones solo esperan 1 o 2 parametros y ya luego se encargar de procesarlos.
                No obstante la API no aceptara ninguno registro que no tenga sus campos,
                Por ende tenemos que obligar clase SendResquest a que solo deje parsar a aquellos objetos que 
                cumplan con la interfaz indicada para poder usar sus funciones.
            */


        }
    }
}   