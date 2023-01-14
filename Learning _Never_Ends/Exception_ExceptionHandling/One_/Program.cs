
    Console.WriteLine("Enter the First_Number");
    int f01= Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the Second_Number");
    int s02= Convert.ToInt32(Console.ReadLine());
// one number is 10 ,other one is 0
    try
    {
            int result = f01 / s02;
            Console.WriteLine("Division is done :{0}", result);
    }
    catch (Exception ex) 
    {
       Console.WriteLine("Your Entered number is Completely Invalid :");
       Console.WriteLine(ex.Message);
    }
        Console.WriteLine("OK");
        Console.WriteLine("Bhola");

    


