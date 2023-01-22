//public (Accessible to other class ,program anywhere)
//If it is not made public ,it tends to be private pikachu 
public class Class1
{
    public void Show1()
    {
        Console.WriteLine("This is the public method ");
    }
    //APPLICABLE TO THE CURRENT CLASS 
    
}

class Program1:Class1
{
    static void Main(string[] args)
    {
        Program1 sujeet=new Program1();
        sujeet.Show1();
        //Class1 bhola = new Class1();
        //Here i am able to access the method created with public 
       // bhola.Show1();

    }
}