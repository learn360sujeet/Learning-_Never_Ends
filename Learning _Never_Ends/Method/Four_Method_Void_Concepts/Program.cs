class Program
{
    public static int Add(int firstNumber,int secondNumber)
    {    // why r we using return ?
        //  because in method we are not assigning void 
        int result = firstNumber + secondNumber;
        return result;

    }
    static void Main()
    {
        Program.Add(1, 2);
        Console.WriteLine(Program.Add(1, 2));
    }
}