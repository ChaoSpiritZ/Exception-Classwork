using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberClass numC = new NumberClass();

            Console.WriteLine("Enter a number from 1-3 to choose an option:");
            Console.WriteLine("1. input a string into an integer");
            Console.WriteLine("2. input 5 numbers into an array");
            Console.WriteLine("3. divide by zero");

            try
            {


                int option = int.Parse(Console.ReadLine());

                if(option == 1)
                numC.GetNumber("b");

                if(option == 2)
                numC.GetNumbers(1, 2, 3, 4, 5);

                if(option ==3)
                numC.DivideByZero(68);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
