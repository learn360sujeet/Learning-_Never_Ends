// This works out with array

int[]Arr=new int[2];
try
{
    Arr[0] = 10;
    Arr[1] = 20;
    //INDEX OUT OF RANGE STARTS HERE
    Arr[2] = 30;
    //Keep loop also bcoz ye jaise hee dekhega limit exceed hai to naatak karega 
    // to isko bhi rakh andar 
    foreach (int i in Arr)
    {
        Console.WriteLine(i);
    }
}
catch(Exception ex)
{
    Console.WriteLine("Your array limit is exceeded");
    Console.WriteLine(ex.Message);
}

