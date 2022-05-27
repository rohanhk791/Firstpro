using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    class DefaultConstractor
    {
        int a, b;
        public DefaultConstractor()   
        {
            a = 100;
            b = 175;
        }

        public static void Main()
        {
            DefaultConstractor obj = new DefaultConstractor(); 
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.Read();
        }
    }
}
