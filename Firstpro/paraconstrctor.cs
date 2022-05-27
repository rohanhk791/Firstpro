using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    class paraconstrctor
    {
        public int a, b;
        public paraconstrctor(int x, int y)  
        {
            a = x;
            b = y;
        }
    }
    class MaiClass
    {
        static void Main()
        {
            paraconstrctor v = new paraconstrctor(100, 175);  
            Console.WriteLine("-----------parameterized constructor example---------------");
            Console.WriteLine("\t");
            Console.WriteLine("value of a=" + v.a);
            Console.WriteLine("value of b=" + v.b);
            Console.Read();
        }
    }
}
