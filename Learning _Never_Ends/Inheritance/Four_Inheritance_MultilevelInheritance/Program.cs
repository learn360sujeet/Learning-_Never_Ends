class Sky
{
    public void Sky_Colour()
    {
        Console.WriteLine("This is the Base Class");
    }
}

class Air:Sky
{
    public void Air_Colour()
    {
        Console.WriteLine("This is the Intermediate class ");
    }
}

class Land :Air
{
    public void Land_Colur()
    {
        Console.WriteLine("This is the Child Class");
    }
}

class Program
{
    static void Main()
    {
        Air obj= new Air();
        obj.Air_Colour();
        obj.Sky_Colour();

        Land obj2 = new Land();
        obj2.Sky_Colour();
        obj2.Air_Colour();
        obj2.Land_Colur();


    }
}