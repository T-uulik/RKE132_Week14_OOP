Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
Dog neighboursDog = new Dog("Good girl");


Console.WriteLine($"My dogs name is {myDog.Name}");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}");

myDog.Rename("Bad girl");
while (myDog.LevelOfHapiness !=5)
{ 
    myDog.Bark();
}

myDog.Tailwag();


class Dog
{
    private string _name;
    private int _levelOfHapiness;
    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-Woof!");
        _levelOfHapiness++;
    }

    public void Tailwag()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}
 


