class UserInput
{
    static void Main()
    {
        //Console.Write(  "Enter your Name :");
        //string userName = Console.ReadLine();
        ////First Ways ..//Concantenation syntax 
        ////Console.WriteLine("Hello, How are you "+ userName);
        ////Second Ways //place holder Syntax
        //Console.WriteLine("Hello, Your name is :{0}",userName);

        //Console.WriteLine("There Was a man named");
        //string named= Console.ReadLine();

        //Console.WriteLine("who worked hard and fear little with bythe");
        //string bythe= Console.ReadLine();

        //Console.WriteLine(" knows :{0} {1}",named,bythe);

        Console.WriteLine("Enter the first number:");
        int fNumber =int.Parse(Console.ReadLine());//Parse takes string value 

        Console.WriteLine("Enter the Second number");
        int sNumber= Convert.ToInt32(Console.ReadLine());

        int result = fNumber + sNumber;
        Console.WriteLine("your desired result is {0} :", result);
       


    }
}