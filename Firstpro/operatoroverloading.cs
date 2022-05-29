using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
    class operatoroverloading
    {
        private int x;
        private int y;
        public operatoroverloading()
        {
        }
        public operatoroverloading(int i, int j)
        {
            x = i;
            y = j;
        }
        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
        public static operatoroverloading operator +(operatoroverloading c1, operatoroverloading c2)
        {
            operatoroverloading temp = new operatoroverloading();
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y;
            return temp;
        }
    }
    class MyComplex : operatoroverloading
    {
        private double x;
        private double y;
        public MyComplex(double i, double j)
        {
            x = i;
            y = j;
        }
        public MyComplex()
        {
        }
        public new void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
    }
    class MyClient
    {
        public static void Main()
        {
            MyComplex mc1 = new MyComplex(1.5, 2.5);
            mc1.ShowXY();
            MyComplex mc2 = new MyComplex(3.5, 4.5);
            mc2.ShowXY();
            MyComplex mc3 = new MyComplex();
            //mc3 = mc1 + mc2;  
            //mc3.ShowXY();  
        }
    }
}

