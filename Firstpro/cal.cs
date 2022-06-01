using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    class cal
    {
        public float Add(float a, float b)
        {
          return  a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class pro
    {
        public static void Main(string[] args)
        {
            cal c = new cal();
           float a= c.Add(10,20.12345f);
            Console.Write(a);
              
        }
    }
}
