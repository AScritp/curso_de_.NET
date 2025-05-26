//--Importamos una librería que nos permite serializar y deserializar objetos a JSON--
using System.Text.Json;

//--Serializar/deserializar un objeto--
//--Meter datos sin usar un constructor--
var miguel = new People()
{
    Name = "Miguel",
    Age = 21
};

//Console.WriteLine(miguel);

string json = JsonSerializer.Serialize(miguel);

Console.WriteLine(json);

string myJson = @"{
    ""Name"": ""Juan"",
    ""Age"": 21
}";

//--Deserializar un objeto--
//-- El simbolo '?' indica que el objeto puede ser nulo, es decir, no se garantiza que siempre tenga un valor. Esto es útil para evitar excepciones de referencia nula (NullReferenceException) al acceder a propiedades o métodos de un objeto que podría no estar inicializado. --
People? juan = JsonSerializer.Deserialize<People>(myJson);

Console.WriteLine($"Me llamo {juan?.Name} y tengo {juan?.Age} años");

public class People
{
    public string Name { get; set; }

    public int Age { get; set; }

    //--Cuando solo tenemos una línea de código, podemos usar '=>' en vez de '{ }'. A esto se le conoce como azurcar sintactica o lambda--
    //public static string Get() => "Hola";

    //public override string ToString()
    //{
    //    return $"Me llamo {Name} y tengo {Age} años";
    //}
    //--Forma tradicional de crear/usar un constructor--
    //public People(string name, int age) { 
    //    Name = name;

    //    Age = age;
    //}

    //public  string GetInfo()
    //{
    //    return $"Me llamo {Name} y tengo {Age} años";
    //}
}
