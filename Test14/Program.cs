Cat newCat = new Cat("Garfield", "ginger");
Console.WriteLine($"{newCat.Name} wants a rub on his belly.");

while (newCat.Bellyfull != 10)
{
    newCat.Sleep();
}
newCat.Meow();
newCat.ShowCatData();
class Cat
{
    private string _name;
    private string _color;
    private int _bellyfull;

    public Cat(string name, string color)
    {
        _name = name;
        _color = color;
        _bellyfull = 10;
        Console.WriteLine($"A {color} cat {name} has been created.");
    }
    public string Name { get { return _name;} }
    public string Color { get { return _color;} }
    public int Bellyfull { get { return _bellyfull;} }
    public void Sleep()
    {
        _bellyfull--;
        Console.WriteLine($"{_name} says: Z-z-Z-z-Z-z");
    }
    public void Meow()
    {
        Console.WriteLine($"{_name} says: Meow!");
    }
    public void ShowCatData()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Level of hungriness: {_bellyfull}");
    }
}