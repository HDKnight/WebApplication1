using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyWord
{
    class ChildClass : BaseClass
    {
        public ChildClass():this(5,6)
        {
            Console.WriteLine("I am ChildClass()");
        }
        public ChildClass(int i)
        {
            Console.WriteLine("I am ChildClass(int i)");
        }
        public ChildClass(int i,int j)
        {
            Console.WriteLine("I am ChildClass(int i,int j)");
        }
    }
}
