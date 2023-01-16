try
{
    //int a = 10;
    //int b = 0;
    //int c = a / b;

    //string userName = null;
    //Console.WriteLine(userName.Length);
    //its INDEX OUT OF RANGE EXCEPTION YET EXCEPTION PARENT EXCEPTION WILL COPE UP WITH THE DISTURBANCES 
    int[]arr =new int[2];
    arr[0] = 1;
    arr[1] = 2;
    arr[2] = 3;

}

catch(DivideByZeroException ex)
{
    Console.WriteLine("Pikachu its inavalid number");
    Console.WriteLine(ex.Message);
}

catch(NullReferenceException ex)
{
    Console.WriteLine("Put the  valid value of string ");
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
//PIKACHU ONE TRY BLOCK WITH ONE CATCH BLOCK WILL EXECUTE AT A TIME 
// BUT CATCH BLOCK MUST BE ARRANGED FROM DOWN TO TOP THAT IS EXCEPTION WILL BE AT THE LAST AND ALL OTHER 
//EXCEPTION WILL BE AT THE TOP 

//eXCEPTION WILL BE ENOUGH TO HANDLE ALL THE ISSUES 
//  