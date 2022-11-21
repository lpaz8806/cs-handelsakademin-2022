namespace L09_IO.Db;

public class Brand
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString() => $"{Name}({Id})";
}