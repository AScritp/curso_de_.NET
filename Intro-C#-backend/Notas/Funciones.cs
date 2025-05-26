
//--INICIO Función de primera clase--
//--Son funiciones que  pueden asignar a variables, pasar como argumentos y retornar desde otras funciones.--
using System;

var show = Show;
//--Ejecuciónn de una función pura
//show("Hola, soy una función de primera clase.");

//--Ejecuciónn de una función de primera clase con un argumento--
Some(show, "Hola, soy una función de primera clase.");
//void Show(string msg)

string Show(string msg)
{
    return msg.ToUpper();
    //Console.WriteLine(msg);
}

//--FIN Función de primera clase--

//-- INICIO Función de orden superior--
//--Son funciones que reciben otras funciones como argumentos o retornan una función como resultado.--
//--Si la función pero no retorna se usa Action<T>--
//void Some( Action<string>fn ,string msg)
void Some(Func<string, string> fn, string msg)
{
    Console.WriteLine("Hago algo al inicio.");
    Console.WriteLine(fn(msg));
    Console.WriteLine("Hago algo al final.");


}

//--FIN
//--INICIO Función pura--
//--Función pura es aquella que no tiene efectos secundarios y siempre devuelve el mismo resultado para los mismos argumentos.--
Console.WriteLine(Sum(4, 2));
int Sum(int a, int b)
{
    return a - b;
}

//--Esto no es una función pura porque hace un calculo interno basado en el tiempo actual y no siempre devuelve el mismo resultado para los mismos argumentos.--
//Console.WriteLine(GetTomorrow());
//DateTime GetTomorrow()
//{
//    return DateTime.Now.AddDays(1);
//}
//--Para arrglarlo podemos pasarle un argumento externo que sea la fecha actual y así no depender del estado interno del sistema.--
//DateTime GetTomorrow(DateTime date)
//{
//    return date.AddDays(1);
//}



var beer = new Beer()
{
    Name = "Corona",
};

Console.WriteLine(ToUpper(beer).Name);
Console.WriteLine(beer.Name);

//-- Otro ejemplo de función no pura--
//Beer ToUpper(Beer beer)
//{
//    beer.Name = beer.Name.ToUpper();
//    return beer;
//}

//--Para arreglarlo podemos crear una nueva instancia de Beer y devolverla sin modificar el objeto original--

Beer ToUpper(Beer beer)
{
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper()

    };
    return beer2;
}
class Beer
{
    public string Name { get; set; }
    public string Price { get; set; }
}

//--FIN Función pura--
