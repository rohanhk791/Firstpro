using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    enum month
        {


            jan = 5,

            feb = 10,

            mar=15,

            apr=20,

            may=25

        }


        class enuma
        {

            static void Main(string[] args)

            {
            Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("The value of jan in month " + "enum is " + (int)month.jan);

                Console.WriteLine("The value of feb in month " +"enum is " + (int)month.feb);

                Console.WriteLine("The value of mar in month " +"enum is " + (int)month.mar);

                Console.WriteLine("The value of apr in month " +"enum is " + (int)month.apr);

                Console.WriteLine("The value of may in month " + "enum is " + (int)month.may);

            }
        }
    }
