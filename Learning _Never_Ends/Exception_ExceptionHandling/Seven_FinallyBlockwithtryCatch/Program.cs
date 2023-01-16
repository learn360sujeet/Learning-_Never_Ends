class Program
{
    static void Main()
    {// 
        try
        {
            int f01 = 10;
            int f02 = 0;
            int c =f01/ f02;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        // ye saala pagal hai isko koi ni fark padta exception aaye na aaye 
        //exception handle kiya hai ki nahi kiya hai kuch bhi ni ye execute ho jaayega 
        finally
        {
            Console.WriteLine("Finally Block executed ");
        }
    }
}// when we are using finally block its ok we can remove catch block 
// exception occurs then by default c sharp will take care of it and then 
// finally block will be executed 

// just check if it is perfroming ot not directly check start without debugiing .