using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberPartial numberPartial =new NumberPartial();
            numberPartial.LargerNumber = 1;
            numberPartial.SmallerNumber= 2;
            Console.WriteLine("your two numbers are :" +numberPartial.GetTheNumber());
            Console.ReadLine(); 
        }
    }
}
