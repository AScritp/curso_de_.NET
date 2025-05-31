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

        static async Task Main(string[] args)
        {
            //-Control de situaciones inesperadas con EXCEPCIONES

            //Un catch general
            /*
            try//<--Obligatorio, para arrancar en un espacio de control de excepciones
            {
                string name = "Miguel";
                var getdisenador = new SearcherDisenadores();
                var description = getdisenador.GetDescriptionByName(name);
                Console.WriteLine($"{name} es {description}");

            }
            catch (Exception ex) //<--Opcional, el catch sirve para atrapar los errores, sirve para ayudar a orientarnos para saber en que fallo
            {                    // pero no es vital para la ejecución del proceso
                Console.WriteLine($"{ex.Message}");
            }
            finally <--Practicamnte obligatorio para que cierre el proceso, sino seguira en ejecución y no estará disponible para su uso
            {
                Console.WriteLine("Tarea terminada");
            }
            */
            //Un catch personalizados, el Visual Studio 2022 nos puede idicar que tipo de fallos ocurren en la ejecución del codigo
            //el orden de ejecución de los catch es el linea, iremos linea por linea viendo los catches que hayan agarrado un error o excepción
            try
            {
                string name = "a";
                var getdisenador = new SearcherDisenadores();
                var description = getdisenador.GetDescriptionByName(name);
                Console.WriteLine($"{name} es {description}");


            }
            catch (InvalidOperationException ex)
            {// <-- Excepción para cuando pongamos en "name" un valor string que no este registrado en los datos que consulta
             //p.e. "A" no existe en la coleción de datos en la por ende da error, pero "Miguel " si existe
                Console.WriteLine("La operación no es valida");
            }
            catch (FieldAccessException ex)
            {
                Console.WriteLine("Cath para el 'FieldAccessException'puesto por el desarrollador ");
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            { //En caso de haber una expeción inesperada que no caiga en las anteriores que son especificasm,
              // entoces caera en esta que es caracter general

                Console.WriteLine($"Excepción inesperada, mensage: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Tarea terminada");
            }
            
         }



    }
}   