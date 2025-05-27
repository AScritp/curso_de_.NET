using System;
using System.ComponentModel;
using System.Linq;
using Intro_C__backend.Models;

namespace Intro_C__backend{
    class Program
    {

        static void Main(string[] args)
        {
            //--Arreglos
            //--Manera manual de declarar un arreglo numero por numero
            //int[] numbers = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //--Manera automatica de declarar un arreglo con LINQ
            int[] numbers = Enumerable.Range(1, 10).ToArray();

            //--Como acceder a un elemento de un arreglo
            //int number = numbers[0];

            //--Modo clasico de recorrer un arreglo con un
            Console.WriteLine($"Resultado del for\n");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"El numero en la posicion {i} es: {numbers[i]}");
            }

            //--Modo moderno de recorrer un arreglo con foreach
            Console.WriteLine($"\nResultado del foreach\n");

            foreach (var number in numbers)
            {

                Console.WriteLine($"{number}");
            }

            //--Otra alternativa
            //int size = 10;
            //int[] numbers = new int[size];
            //numbers = Enumerable.Range(1, size).ToArray();

            Console.WriteLine("*********************************************");
            //--Listas

            //--Del tipo apilamiento.
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7 };
            list.Add(8); //--Agrega un elemento al final de la lista.
            list.Remove(1);

            foreach (int numero in list)
            {
                Console.WriteLine("El numero en la lista es: " + numero);
            }

            Console.WriteLine("*********************************************");

            //--Manera 1 de añandir un elemento a una lista
            List<Sofases> sofas = new List<Sofases>(){new Sofases ("España", 47000000, "001", "Max Comfort", "Blanco", 10)};

            //--Manera 2 de añadir un elemento a una lista
            sofas.Add(new Sofases("Portugal", 30000000, "003", "Luxury", "White", 5));


            //--Manera 3 de añadir un elemento a una lista
            Sofases happy_days = new("Reino Unida", 100000000, "005", "Happy Days", "Rojo", 5);
            sofas.Add(happy_days);

            foreach (var sofa in sofas) 
            {
                Console.WriteLine(sofa.Nombre);
            }

            //--Del tipo cola.
        }
    }

   
}