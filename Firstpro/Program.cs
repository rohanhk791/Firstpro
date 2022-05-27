using System;

namespace Firstpro
{
    class Program
    {
        int i;
        bool b;

        static void Main(string[] args)
        {

            ///implicitly//
            Program p = new Firstpro.Program();
            Console.WriteLine("the value of i is  : " + p.i);
            Console.WriteLine("the value of b is  : " + p.b);
            Console.ReadLine();

        }
        }
}



