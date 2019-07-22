using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Classwork
{
    class NumberClass
    {
        public NumberClass()
        {
        }

        public void GetNumber(string x)
        {
            try
            {
                int y = int.Parse(x);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetNumbers(int num1, int num2, int num3, int num4, int num5)
        {
            try
            {
                int[] array = new int[4];

                array[0] = num1;
                array[1] = num2;
                array[2] = num3;
                array[3] = num4;
                array[4] = num5;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DivideByZero(int x)
        {
            try
            {
                x /= 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
