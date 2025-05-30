using Intro_C__backend.Models;
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
            // LINQ: modificar y obtener objetos complejos con subconsultas
            // Creo una lista de con las propiedades de la clase empresa, para asingar a un nuevo objeto
            List<Empresa> empresas = new List<Empresa>()
            {
                //Creo 3 objetos, 2 con una lista de 3 objtos de la clase disenadores con sus respectivas propiedades
                //Y 1 objeto de clases empresas vacio
                new Empresa("SQL Disyners")
                { 
                    disenadores = new List<Disenadores>(){
                        new Disenadores(){Id="001", Name="Miguel", Lastname="López", Description="Estudiante" },
                        new Disenadores(){Id="002", Name="Juan", Lastname="Alemany", Description="Profesor" },
                        new Disenadores(){Id="003", Name="Alex", Lastname="Cascales", Description="Estudiante" },
                    }
                },
                new Empresa("NODE Style")
                { 
                    disenadores = new List<Disenadores>(){
                        new Disenadores(){Id="004", Name="Sergi", Lastname="Romero", Description="Profesor" },
                        new Disenadores(){ Id = "005", Name = "Laura", Lastname = "García", Description = "Diseñadora gráfica" },
                        new Disenadores(){ Id = "006", Name = "Alex", Lastname = "Martínez", Description = "Diseñador UX/UI" }

                    }
                },
                new Empresa("Ubisoft"),

                new Empresa("Confor Sits"){ 
                
                    sofases = new List<Sofases>()
                    {
                        new Sofases("ES", "España", 47000000, "SF001", "Sofá Madrid", "Gris", 10),
                        new Sofases("FR", "Francia", 67000000, "SF002", "Sofá París", "Azul", 8),
                    }
               
                },
                 new Empresa("noseKsofas")
                 {
                     sofases= new List<Sofases>()
                     {
                        new Sofases("ES", "España", 47000000, "SF001", "Sofá Madrid", "Gris", 10),
                        new Sofases("IT", "Italia", 60000000, "SF003", "Sofá Roma", "Rojo", 12),
                        new Sofases("DE", "Alemania", 83000000, "SF004", "Sofá Berlín", "Negro", 15)
                     }
                 }
            };
            //Aquí con el LINQ, guardo los datos del objeto empresas de tipo lista en "emp"
            //y le digo que DONDE encuentre en uno de las empresas un diseñador DONDE tenga el Name igual a "Alex" y si el numero de match es mayor a "0"
            //haga un select el cual tiene que ser en tipo de lista.

            //Esto nos manda todos los datos de los objetos tengan en el campo Name el valor "Alex"
            var empresa = (from emp in empresas
                           where emp.disenadores.Where(d=>d.Name=="Alex").Count()>0
                           select emp).ToList();

            // Pero si tenemos tabla con mas de 80 propiedas/columnas nesetimos saber sacar solo lo que nos intesa
            //Creamos una nueva clase llamada EmpresaData y pondremos los datos escenciales


            //Para este ejemplo le hechamos imaginación porque relación de objetos y clases es una mierda en todo los sentido
            //Imaginemos que la consulta de de Sofases, pero solo me interesa el pais de fabricación nada mas
            //con ayuda de la Clase EmpresaData haremos el filtro de información
            
            var empresa2 = (from emp2 in empresas
                           where emp2.sofases.Where(s => s.CodigoP == "ES").Count() > 0
                           select new EmpresaData(emp2.Nombre) { //<-- aqui hacemos select a la clase EmpresaData donde en teoria 
                                                                 //tendria una clase padre con menos propidades de las cuales se alimenta el hijo que definimos arriba
                                                                 
                                 pais = (from p in emp2.sofases //<-- Definimos la lista que esta en EmpresaData y hacemos una SUB-Consulta
                                       select new Paises (p.Codigo,p.Nombre,p.NumHabitantes)//<--Definimos paises y solo ponemos los parametros de su constructor que son 3
                                                                                            // sin tener que pasar por el de sofases que son 7
                                       ).ToList()//<-- Que lo muestre en modo lista para que coincidan con el tipo de dato.
                           }        
                           ).ToList();



        }

    }
}   