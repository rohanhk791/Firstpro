using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    class overhide
    {
        public void display()
        {
            Console.WriteLine("Super class  method");
        }
    }
    class Class2 : overhide
    {
        public new void display()
        {
            Console.WriteLine("Sub class  method");
        }
    }
    class Program2
    {
        static void Main(string[] args)
        {
            overhide obj = new Class2();
            obj.display();
            Console.ReadKey();
        }
    }
}
