using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    class baseClass
    {
        public virtual void Greetings()
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }
    class subClass : baseClass
    {
        public override void Greetings()
        {
            base.Greetings();
            Console.WriteLine("subClass Saying Hello!");
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            baseClass obj1 = new subClass();
            obj1.Greetings();
            Console.ReadLine();
        }
    }
}
