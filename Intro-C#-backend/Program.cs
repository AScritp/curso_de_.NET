using Intro_C__backend.Errors;
using Intro_C__backend.Models;
using Intro_C__backend.Services;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Linq; //--Extensión de SQL
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json; //--imports para la des/serialización JSON
using System.Text.Json.Serialization;//--imports para la des/serialización JSON
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Intro_C__backend{
    class Program
    {
        //Function, el problema de "delegate" que es que si queremos trabajar con distintos elemetos no se puede, ademas no poder usar mas de uno por metodo
        //Aquí entra Func, que puede soportar hasta 16 parametros, de los cuales el ultimo a la derecha está reservado para envia
        //los otros reciben
        static async Task Main(string[] args)
        {
            //Delegados,Func y Actions
            Func<string, string,int> mostrar =shownum;//<-- Volvemos a delegar, pero con la direncia que rebira 2 parametros sting, y su return será int
            HacerAlgo(mostrar);

        }

        public static void HacerAlgo(Func<string,string, int>funcion_final) // <--Primero arranca "HacerAlgo" con los parametros que seran delegados a otro.
        {
            Console.WriteLine("Ejemplo 1: \n");
            Console.WriteLine("¿Cuantos caracteres tiene:\n \"hola vengo de otra función\"?\n");// <--Hace su función
            Console.WriteLine($"Tiene: {funcion_final("hola ","vengo de otra función")}.");//<--aqui el parametro recibe los 2 string y los manda a la función 
            
        }

       
        public static int shownum(string cadena, string cadena2)//<--Le llega acá los 2 parametro delegados
        {
            var upper = cadena + cadena2;//<-- hace su función
            return upper.Count();//<-- retorna un int 
            
        }
        //Con esto se demuestra que cuando vamos a hacer muchas delegaciones FUNC es la con mejor escalabilidad.
 
    }
}   