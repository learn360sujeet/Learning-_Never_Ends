using System.Runtime.CompilerServices;

class Constructor
{
    string personName;
    int age;
    bool male;

    public Constructor(string personName, int age, bool male)
    {
        this.personName = personName;
        this.age = age;
        this.male = male;
    }

    public string GetName()
    {
        return this.personName;
    }
    public int GetAge()
    {
        return this.age;
    }
    public bool GetMale()
    {
        return this.male;
    }
    static void Main()
    {
        Constructor constructor = new Constructor("Bhola", 25, true);

        Console.WriteLine("your name is "+ constructor.GetName());
        Console.WriteLine("your age is "+ constructor.GetAge()) ;
        Console.WriteLine( "are you male"+constructor.GetMale()); 
    }

    
}