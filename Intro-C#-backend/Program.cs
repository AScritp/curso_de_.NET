using Intro_C__backend.Errors;
using Intro_C__backend.Models;
using Intro_C__backend.Services;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Linq; //--Extensión de SQL
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
        //Los delagos permiten que las funciones puedan otras funciones internas
        public delegate void Mostrar(string cadena); //<--Creamoos una "firmar" que permite delegar una función
        public delegate string Mostrar2(string cadena2); //<--Esto es para dar un ejemplo de un metodo "VOID" de los otros
        static async Task Main(string[] args)
        {
            //Delegados,Func y Actions
            Mostrar mostrar = show; //<-- Aqui que le decimos a el metodo "show" que trabajara con los resultado delegados de otro
            HacerAlgo(mostrar,"hola");//<-- Aqui le asignamos al metodo "HacerAlgo" la firma de delegación que creamos,
                                      //para que puedea ceder sus procesos a otro metodo

            
            Mostrar2 mostrar2 = show2;
            HacerAlgo2(mostrar2,"hola2");
        }

        public static void HacerAlgo(Mostrar funcion_final,string hola) // <--Primero arranca "HacerAlgo" con un parametro que sera el
                                                            // delegado a otro.
        {
            Console.WriteLine("Ejemplo 1: \n");
            Console.WriteLine("1.Hago mis procesos");// <--Hace su función
            funcion_final($"{hola} vengo de otra función");//<--Luego el resultado lo manda al parametro
        }
        
        public static void show(string cadena)//<--Le llega acá el parametro delegado
        {
            Console.WriteLine("Parametros delegado: " + cadena);//<-- Aqui contatenamos el resultado de "show" 
                                                                 //con el parametro delegado
        }

        public static void HacerAlgo2(Mostrar2 funcion_final2, string hola2)
        {
            Console.WriteLine("\nEjemplo 2:\n");
            Console.WriteLine("2.Hago mis procesos");
            Console.WriteLine(funcion_final2($"{hola2} vengo de otra función"));
        }


        public static string show2(string cadena2)
        {   var result = $"{cadena2}";
            Console.WriteLine($"Hago cosa x: {result}");
            return result.ToUpper();
        }
    }
}   