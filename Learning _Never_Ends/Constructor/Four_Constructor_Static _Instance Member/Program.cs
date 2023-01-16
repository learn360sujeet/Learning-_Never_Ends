class Village
{// by default its private pikachu 
  

    // either its member or method if STATIC IS NOT MENTIONED ITS INSTANCE (OBJ)
   public  string _villageName;
   public  int _villageId;
   public bool _villageEnabled;
    public static string village_Name;

    //CREATE THE INSTANCE OBJECT 
    

}

class Program
{
    static void Main()
    {
        Village obj= new Village();
        Village.village_Name = "Test ";
        Console.WriteLine(Village.village_Name);

        obj._villageEnabled= true;
        obj._villageId= 1;
        obj._villageName= "test";
        Console.WriteLine("Your all the information is {0},{1},{2}", obj._villageEnabled, obj._villageId,obj._villageName);
    }
}