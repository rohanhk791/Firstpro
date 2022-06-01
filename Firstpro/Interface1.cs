using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    interface Interface1
    {
       abstract void add(int a, int b);
    }
    interface inter 
    {
       abstract void sub(int a, int b);

    }


    class imp : inter,Interface1 
    {
        
       

       

        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main()
        {
            imp i = new imp();
            i.add(10, 20);
            i.sub(20, 10);

        }
    }





}

