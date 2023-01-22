class Method_Concepts
{ 
    //Declared a Method //Non static //Instance method 
    //Declared inside a class only 
    public void Bhola_Method()
    { //Group pf statements 
        Console.WriteLine("\"Here your learning of method starts\"");
        Console.WriteLine("Method is declared when we want to execute a group of statements to perform a specific task ,for that we cant method and put all the staemts inside of it ");
    }
    //Declaring Method //static method //not a insantance method 
    public static void Bhola_Method1()
    {
        Console.WriteLine("Your name is not here bhola");
        Console.WriteLine("Hi this is bhola prasad ");
    }
     static void Main(string[] args)
     {
        Console.BackgroundColor = ConsoleColor.Red;
        Method_Concepts method_concepts = new Method_Concepts();
        //Call the method 
        method_concepts.Bhola_Method();
        //Method is Reuseable
        method_concepts.Bhola_Method();
        //Call the static method 
        Method_Concepts.Bhola_Method1();
        //Method is reuseable
        Method_Concepts .Bhola_Method1 ();  
     }
    
    

}