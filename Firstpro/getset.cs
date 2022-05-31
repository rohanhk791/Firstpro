using System;

namespace Firstpro
{
    class getset
    {
        private string SName;
        public getset(string name) => SName = name;
        public string Name
        {
            get => SName;          
            set => SName = value;    
        }
    }
    class getsetprogram
    {
        public static void Main()
        {
            getset stu = new getset("rohan gowda");
            Console.WriteLine(stu.Name);
        }
    }

}

