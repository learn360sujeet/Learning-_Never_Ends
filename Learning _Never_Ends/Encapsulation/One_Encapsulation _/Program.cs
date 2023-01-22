class Human_Demo
{
    //  Keep it private while you are using the concepts of Encapsulation 
    private string humanName;

    //Method to set the value 
    public void SetName(string Name)
    {
        this.humanName = Name;
    }
    public void GetName()
    {
        Console.WriteLine("Your name is "+this .humanName);
    }

}

class Program
{
    static void Main(string[] args)
    {
        Human_Demo hd= new Human_Demo();
       
        hd.GetName();
        hd.SetName("Bhola");

        
    }
}