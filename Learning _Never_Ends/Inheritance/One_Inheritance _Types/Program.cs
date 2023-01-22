class BaseClass
{
    public void ShowMe()
    {
        Console.WriteLine(" this is the base class ");
    }
}

class DeriveClass:BaseClass
{
    public void ShowYou()
    {
        Console.WriteLine("tHIS IS THE DERIVE CLASS BABES ");

    }
}

class Program
{
    static void Main()
    { //DeriveClass actually inherited Base Class
        // creating the drive class object
        // ,we can access both the features of the classes 
        DeriveClass bholeshanakr= new DeriveClass();
        bholeshanakr.ShowMe();
        bholeshanakr.ShowYou();
        

    }
}