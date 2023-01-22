class SujeetVillage:Village 
{
    public string userProfession ;
    public int userMember;


}

class AjeetVillage:Village
{
    public string userProfession;
    public int userMember ;


}

class Village
{
    public string userName ;
    public int usernumbers;
    public int userAge ;
    public int contactNumber ;

    public void Display()
    {
        Console.WriteLine("This is the base class ");
    }
}
class Program
{
    static void Main(string[] args)
    {
        AjeetVillage aj=new AjeetVillage();
        aj.usernumbers = 1;
        aj.userProfession = "A";
        aj.userMember = 1;
        aj.contactNumber = 2;
        
        SujeetVillage bj=new SujeetVillage();   
        bj.usernumbers=1;
        bj.userMember=2;
        bj.userProfession="B";
        bj.contactNumber=3;
        bj.Display();
        

        Console.WriteLine(aj.usernumbers);
        Console.WriteLine(bj.usernumbers);

        


    }
}