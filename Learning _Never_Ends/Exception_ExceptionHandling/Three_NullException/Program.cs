try
{
    string name = null;
    Console.WriteLine(name.Length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("String is null");
    Console.WriteLine(ex.Message);
}