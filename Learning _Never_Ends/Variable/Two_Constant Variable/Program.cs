//Const value can be declared in the class level or method level
class Program_Constant
{    //public (keep in class level to be accessed in all the class )
	//PUBLIC WONT BE USED IN METHOD BLOCK .
	//CONST VARIABLE WE CAN USE IN CLASS AS WELL AS METHOD LEVEL
	 // value will never change pikachu when u use CONST
	 //public const int firstNumber = 100;

      // public const string companyName = "Test";

	//PIKACHU ALWAYS GIVE VALUE TO CONST OTHERWISE RED GONNA HAPPEN (COMPILER ERROR )
	static void Main(string[] args)
	{

         const string companyName = "Test";

		//try to change the value of 
		//firstNumber = 200;(SEEN NOT ALLOWED )
		//Console.WriteLine(firstNumber);
		Console.WriteLine(companyName);

}
}
// INTERVIEW QUESTION SNIPPET CHANGED LOOKM IINTO IT .