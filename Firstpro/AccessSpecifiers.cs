using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstpro
{
   
        class AccessSpecifiers
        {
            public string name = "Rohan gowda";
            public void Msg(string msg)
            {
                Console.WriteLine("Hello " + msg);
            }
        }
        class Access
    { 
            static void Main(string[] args)
            {
            AccessSpecifiers publicTest = new AccessSpecifiers();
                // Accessing public variable  
                Console.WriteLine("Hello " + publicTest.name);
        // Accessing public function  
        publicTest.Msg("good afternoon");
                    }
        }
}
