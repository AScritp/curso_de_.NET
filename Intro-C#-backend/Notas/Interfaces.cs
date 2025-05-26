using System;

Sale sale = new();
var beer = new Beer();

Some(sale);
Some(beer);

//-- Some es una función que acepta cualquier objeto que implemente la interfaz ISave.
void Some(ISave save)
{
    save.Save();
}

//--Interfaces, son reglas que aplicamos a nuestras clases para cumplir unos requisitos minimos.

//La interfaz ISale define una propiedad Total y la interfaz ISave define un método Save.
interface ISale
{
    public decimal Total { get; set; }
}

interface ISave
{
    public void Save();
}

//--Solo podemos implementar una interfaz cuando la clase implementa todos los miembros de la interfaz.
//--Una clase pu implementar varias interfaces, pero no puede heredar de varias clases.
class Sale : ISale, ISave
{
    public decimal Total { get; set; }

    public void Save()
    {
        Console.WriteLine("Sale saved with total: " + Total);
    }
}
class Beer : ISave
{
    public void Save()
    {
        Console.WriteLine("Beer saved.");
    }
}
