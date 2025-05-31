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
    static class Program
    {
        //PREDICADO, sentencia que regresa TRUE o FALSE

        public class Beer { 
            public string Name { get; set; }
            public int Alcohol { get; set; }
        }
        static async Task Main(string[] args)
        {

            List<Beer> beers = new List<Beer>() {
                new Beer{Name="Shandy", Alcohol=1},
                new Beer{Name="Ipa", Alcohol=8},
                new Beer{Name="Tripel", Alcohol=15},
                new Beer{Name="Stout", Alcohol=9},
            };

            beers.ShowMeThatBeersThatIGetDrunk( x => (x.Alcohol >= 8 && x.Alcohol<15));

        }

        static void ShowMeThatBeersThatIGetDrunk(this List<Beer> beers , Predicate<Beer> condition) 
        {
            var get_me_drunk = beers.FindAll(condition);
            
            get_me_drunk.ForEach(g => Console.WriteLine(g.Name));
        }
        
    }
}   