// <--INICIO Maneras de difinir un objeto -->
//SALES sale = new SALES();
//sale.TotalSales = 15;

//var sale = new SALES();
//sale.TotalSales = 15;

//SALES sale = new();
//sale.TotalSales = 15;
// <--FIN Maneras de difinir un objeto -->

//SALES sale = new(15);
var SaleP = new SALES(15);
var InfoP = SaleP.GetInfo();
Console.WriteLine(InfoP);



SALESWITHTAX SaleChil = new SALESWITHTAX(19, 0.16m);
var InfoChil = SaleChil.GetInfo();
Console.WriteLine(InfoChil);
//--Descomentar couandoo la propiedad sea public
//Console.WriteLine(SaleP._Simbolo);
//Console.WriteLine(GetInfoProtec());

class SALESWITHTAX : SALES
{
    private decimal _Tax { get; set; }

    //--Override indica a la clase hija que va a sobreescribir la propiedad de la clase padre
    //--La clase puede agregar nuevos valores
    public SALESWITHTAX(decimal total, decimal tax) : base(total)
    {
        _Tax = tax;
        Console.WriteLine(GetInfoProtec());
    }

    public override string GetInfo()
    {
        return $"El total es; {TotalSales}$ y el impuesto es: {_Tax}$";
    }

    //--Sobrecarga de operadores; permite definir múltiples métodos con el mismo nombre dentro de una clase, pero con listas de parámetros diferentes.
    public string GetInfo(string InfoChil)
    {
        return InfoChil;
    }

}


class SALES
{
    //--Pulbic properties para poder acceder desde fuera de la clase
    public decimal TotalSales { get; set; }
    //public string _Simbolo = "$";
    //--Private properties para poder acceder SOLO dentro de la clase
    private string _Simbolo = "$";

    public SALES(decimal total)
    {
        TotalSales = total;
    }

    //-- Virtual indica que es la propiedad que se puede sobreescribir en la clase hija
    public virtual string GetInfo()
    {
        return $"El total es; {TotalSales}{_Simbolo}";
    }

    //--La propiedades con "protected" solo se pueden acceder desde la misma clase o desde una clase hija que herede de ella
    protected string GetInfoProtec()
    {
        return $"--Esta es una propiedad protegida--";
    }


}
