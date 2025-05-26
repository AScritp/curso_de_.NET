//--Los LINQ son una forma de consultar datos en C#, tienen 3 partes:
// 1. Fuente de datos
var names = new List<string>
{
    "Miguel",
    "Alex",
    "Juanma",
    "Daniel"
};

// 2. Consulta
//Tambien se puede usar puertas logicas como where, &&,orderby, etc.

var namesr = from n in names
             where n.Length > 3 && n.Length < 6
             orderby n descending
             select n;

// 2.1 Consulta
//Tambien se puede usar un función lambda para hacer la consulta
var namesr2 = names.Where(n => n.Length > 3 && n.Length < 6)
                  .OrderByDescending(n => n)
                  .Select(n => n);

// 3. Ejecución
foreach (var name in namesr)
{
    Console.WriteLine(name);
}

foreach (var name in namesr2)
{
    Console.WriteLine(name);
}
