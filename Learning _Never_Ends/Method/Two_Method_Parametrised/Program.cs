class Bhola_Details
{
    //Prametrized Method
    //Passing the parameter
    //public static void ShowBhola(string userNmae, int userAge, bool Male)
    //{
    //    Console.WriteLine("Your gender is Male:" + Male);
    //    Console.WriteLine("Hello{0}", userNmae);
    //    Console.WriteLine(" Your age is this {0},{1}", userNmae, userAge);
    //}


    //static void Main()
    //{    //Call the method using the class name as it is static 
    //    Bhola_Details.ShowBhola("Bhola", 25, true);//arguements

    //}

    public static void UserInput()
    {
        Console.Write("Enter the first number of your choice :");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second Number of you choice :");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int result = firstNumber + secondNumber;
        Console.WriteLine("Show the number "+result);
    }
    static void Main()
    {
       Bhola_Details.UserInput();
    }

    
    cw

    
}
