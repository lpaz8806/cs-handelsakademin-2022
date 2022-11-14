namespace L07_Interfaces.Examples.Abstract;

public interface IProduct
{
    string Name { get; }
    int Price { get; }
    string ArtikelNumber { get; }

    void Buy();
}

abstract class ProductBase : IProduct
{
    public string Name { get; }
    public int Price { get; }
    public string ArtikelNumber { get; }
    
    public abstract void Buy();
}

class PhysicalProduct : ProductBase
{
    
    public override void Buy()
    {
        throw new NotImplementedException();
    }
}

class DigitalProduct : ProductBase
{
    public override void Buy()
    {
        throw new NotImplementedException();
    }
}