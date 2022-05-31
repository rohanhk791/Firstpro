using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    interface Interface1
    {
        void add(int a, int b);
    }
    interface inter : Interface1
    { 
        void sub(int a, int b);

    }
    class imp : inter
    {
        public void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    
    static void Main()
        {
            imp obj = new imp();
            obj.add(10, 20);
            obj.sub(30, 10);
            Console.ReadLine();
        }
    
    }





}

