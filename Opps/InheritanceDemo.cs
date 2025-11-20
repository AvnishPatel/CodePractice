using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Opps
{
    public class A
    {
        public virtual void Show()
        {
            Console.WriteLine("From Class A");
        }
    }

    public class B : A
    {
        public override void Show()
        {
            Console.WriteLine("From Class B");
        }
    }

    public class C : B
    {
        public new void Show()
        {
            Console.WriteLine("From Class C");
        }

    }
}
