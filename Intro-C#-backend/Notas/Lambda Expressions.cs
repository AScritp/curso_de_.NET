//--Demostración de Lambda Expressions en para crear una función sencilla rapidamente en C#--
//--este tipo de funciones se pueden usar para crear funciones anónimas, perfectas para funciones de clase superior que se alimenta de ellas--
//Func<int, int, int> sum = ( int a,  int b) => a - b;
//--En C# tambien se puede ahorrar/omitir el tipo de dato de los parametros si se conoce--
//Func<int, int, int> sum2 = (a, b) => a - b;

//Func<int, int> some = (a)=> a * 2;
//--En C# tambien se puede ahorrar/omitir los parentesis si solo tenemos un parametro de entrada--
//Func<int, int> some = (a) => a * 2;
//--Ejemplo de una funcion que recibe una funcion anonima como parametro--
//--Como primer parametro la función de primera clase se alimenta de una función anonima que tiene 2 paramentros que se suman--
//--Como segundo parametro la función de primera clase se alimenta de un int de valor 5--

Some((a, b) => a + b, 5);

//-- La función de primera clase tiene 2 parametros de entrada y 1 de salida
//fn guarda la función anónima y number guarda el valor 5
void Some(Func<int, int, int> fn, int number)
{
    //--El objeto result ejecuta la fución anónima teniendo como parámetros el valor de number
    var result = fn(number, number);
}

