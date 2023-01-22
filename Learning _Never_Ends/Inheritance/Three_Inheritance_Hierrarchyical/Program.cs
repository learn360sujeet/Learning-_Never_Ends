class Father_Attributes
{
     public void Show3()

     {
        Console.WriteLine("FATHER");
     }
     

}

class Son_Attributes:Father_Attributes  
{
    public void Show2()
    {
        Console.WriteLine("SUJEET");
    }
   
}

class Son2_Attributes :Father_Attributes
{
    public void Show()
    {
        Console.WriteLine("AJEET");
    }
}

class Program
{
    static void Main()
    {
        Son_Attributes bhola=new Son_Attributes();
        bhola.Show3();
        bhola.Show2();
       
        Son2_Attributes kaivlya =new Son2_Attributes();
        kaivlya.Show3();
        kaivlya.Show();


        
    }
}