// Una lista permite almacenar una coleccion de elementos de cualquier tipo.
var number = new MyList<int>(5);
var name = new MyList<string>(5);
var beer = new MyList<Beer>(3);

//--Generics pertime hacer genericos las clases, metodos, interfaces, etc. Para reutilizar el codigo y que sea mas flexible.

number.Add(1);
number.Add(2);
number.Add(3);
number.Add(4);
number.Add(5);
number.Add(6); // No se agrega porque el limite es 5


name.Add("Juan");
name.Add("Maria");
name.Add("Pedro");
name.Add("Ana");
name.Add("Luis");
name.Add("Carlos"); // No se agrega porque el limite es 5

beer.Add(new Beer { Name = "Corona", Price = "$2.00" });
beer.Add(new Beer { Name = "Modelo", Price = "$2.50" });
beer.Add(new Beer { Name = "Heineken", Price = "$3.00" });
beer.Add(new Beer { Name = "Budweiser", Price = "$2.75" }); // No se agrega porque el limite es 3

Console.WriteLine($"Lista de números: \n {number.Get()}");
Console.WriteLine($"Lista de nombres: \n {name.Get()}");
Console.WriteLine($"Lista de cervesas: \n {beer.Get()}");


public class MyList<T>
{
    //-- List es un tipo de dato generico que permite almacenar una coleccion de elementos de un tipo especifico.
    private List<T> _list; // indicamos que guarde memoria para una variable de tipo List<T>
    private int _limit;

    // Constructor que inicializa la lista y el limite
    public MyList(int limit)
    {
        _limit = limit; // Indicamos el limite de la lista
        _list = new List<T>(); // Creamos la variable lista de tipo T
    }
    // Metodo para agregar un elemento a la lista
    public void Add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
    }

    // Metodo para obtener un elemento de la lista por su indice
    public string Get()
    {
        string content = "";
        foreach (var element in _list)
        {
            content += element + "; ";
        }
        return content;
    }


}


public class Beer
{
    public string Name { get; set; }
    public string Price { get; set; }

    public override string ToString()
    {
        //--Una forma de mostrar el objeto Beer como una cadena de texto
        return (Name + " " + Price);

        //--Otra forma de mostrar el objeto Beer como una cadena de texto
        //return $"{Name} {Price}";

        //--Otra forma de mostrar el objeto Beer como una cadena de texto
        //return "Nombre: "+Name + ", Precio: " + Price;

    }

}

