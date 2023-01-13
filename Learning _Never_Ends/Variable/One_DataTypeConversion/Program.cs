//Pikachu there is two types of conversion 
// Implicit conversion is done by the compiler itself

//Explicit is done by the programmer itself

class Program
{
	static void	 Main(string[] args)
	{
        //Implicit Done smaller to bigger value 
        //int a = 100;
        //float b = a;
        //Console.WriteLine(b);


        ///Explicit done by the two ways 
        /////OR ,CONVERT.TOINT32
        //  float f = 100.00f;
        // int d = (int)f;
        // Console.WriteLine(d);


        //string m = "60";
        //string l = "40";

        //float c = float.Parse(m) + float.Parse(l);
        //Console.WriteLine(c);


        Console.WriteLine("Enter the number of your choice ");
        int usernumber=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the name of your choice ");
        string name = Console.ReadLine();

        
        Console.WriteLine("The number is {0}: and the name is{1} ",usernumber,name ); 
    }

}