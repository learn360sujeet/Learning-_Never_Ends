
Console.WriteLine("Enter a number");

string number=Console.ReadLine();
try {
    int number1 = int.Parse(number);
    Console.WriteLine("Number is " + number1);
    }
catch (FormatException ex)
      {
          Console.WriteLine("its inavlid to change number to string ");
          Console.WriteLine(ex.Message);
      }
