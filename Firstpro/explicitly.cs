using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    class explicitly
    {
        public explicitly()
        {
            Console.WriteLine("constructor called");
        }

        static void Main()
        {
            explicitly obj = new explicitly();
            explicitly obj1 = new explicitly();
            explicitly obj2 = new explicitly();

            Console.ReadLine();
        }

        }
}
