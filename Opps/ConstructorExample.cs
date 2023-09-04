using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Opps
{
    class ParentClass
    {
        static ParentClass()
        {
            Console.WriteLine("Static constructor of ParentClass Called");
        }
        public ParentClass()
        {
            Console.WriteLine("Non-Static constructor of ParentClass Called");
        }
    }

    class ChildClass : ParentClass
    {
        static ChildClass()
        {
            Console.WriteLine("Static constructor of ChildClass Called");
        }
        public ChildClass()
        {
            Console.WriteLine("Non-Static constructor of ChildClass Called");
        }
    }

}
