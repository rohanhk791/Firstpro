using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    class Exceptions
    {
        public static void Main()
        {
            int[] a = { 2, 4, 6, 8, 10, 12, 14 };//7 elements
            int[] b = { 2, 0, 3, 4, 0 };//5 elements
            //Loop through the arrays a and b based on the lenght of array a
            for (int i = 0; i < a.Length; i++) //7
            {
                try
                {
                    Console.WriteLine(a[i] / b[i]); //a[5]/b[5]
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                

            }
        }
    }
}
