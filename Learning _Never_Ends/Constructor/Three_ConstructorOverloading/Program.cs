class Program
{
    //But with different parameters 
    //A single class may have as many constructor but with different signatures .
    public Program()
    {
        Console.WriteLine(  "This is first Constructor");
    }

    public Program(int a ,int b)
    {
        
        Console.WriteLine("Second Constructor  is {0}",(a+b));
    }

    public Program(string a,string b)
    {
        Console.WriteLine("your name is {0},{1}",a,b);
    }

    public Program (int a ,int b,int c)
    {
        Console.WriteLine("The desired number is {0}",(a + b + c));
    }
        



    
    static void Main ()
    {
        Program program = new Program(25,20);
        Program name = new Program("Sujeet", "Bhola");
        Program integers= new Program(20,20,20);    
    }


}