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
        //Action
        static async Task Main(string[] args)
        {
            //Delegados,Func y Actions
            Action<string, string> mostrar =shownum;//<-- Action es casi lo mismo que Function, solo que este solo recibe y no retorna
            HacerAlgo(mostrar);

            //TIP
            //En vez de gastar lineas de cogido para para hacer funciones que solo se usen solo una vez como shownum
            //Podemos hacer una función anonima con expresión lambda
            //p.e: Action<string, string> mostrar = (a,b)=> Console.WriteLine(a+b);
        }
        public static void HacerAlgo(Action<string,string>funcion_final) // <--Primero arranca "HacerAlgo" con los parametros que seran delegados a otro.
        {
            Console.WriteLine("Ejemplo 1: \n");
            Console.WriteLine("¿Cuantos caracteres tiene:\n \"hola vengo de otra función\"?\n");// <--Hace su función
            funcion_final("hola ","vengo de otra función");//<--Aqui quitamos el Console.WriteLine porque no va a recibir ningun valor que imprimi, solo se envia.
        }
        public static void shownum(string cadena, string cadena2) //<-- cambiamos a void y hacemos la parte de contar e imprimir aqui mismo
        {
            var num= cadena+cadena2;
            Console.WriteLine($"\nTiene: {num.Count()}");
        }
    }
}   