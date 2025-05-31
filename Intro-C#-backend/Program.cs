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
        //PREDICADO, sentencia que regresa TRUE o FALSE
        static async Task Main(string[] args)
        {
            var list = new List<int>() {0,17,24,33,74,55,76,73,86,98 };//<--Para este ejemplo creo una lista de numeros, para luego ver cuales son divisibles entre 2
            var predicate = new Predicate<int>(N => N % 2 == 0); //<-- Creo el Predicate y con una función anonima le establesco las condiciones para que haga TRUE o FALSE
            Predicate<int> NegativePredicate = x => !predicate(x);//<-- Tambien podemos crear PredicateNegativos de esta manera, por si no me interesa los divisibles entre 2
                                                                  //y provechando el predicate de arriba
            var diviver1=list.FindAll(predicate);//Uso una función de List<> llamada FindAll y pongo mi objeto predicate como la condición para hacer match
            var diviver2=list.FindAll(NegativePredicate);


            Console.WriteLine($"Divisibles entre 2:\n");
            diviver1.ForEach(p => { Console.WriteLine(p); });//Uso expresión Lambda para imprimir un foreach

            Console.WriteLine($"\nNo divisibles entre 2:\n");
            diviver2.ForEach(p => { Console.WriteLine(p); });


        }

        static bool IsDivider(int N) => N % 2 == 0;
    }
}   