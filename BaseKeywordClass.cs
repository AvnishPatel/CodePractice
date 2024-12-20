using System;

namespace CodePractice
{
    public class BaseClass
    {
        public virtual void Greet()
        {
            Console.WriteLine("Hi from BaseClassDemo");
        }
    }

    public class ChildClass : BaseClass
    {
        public override void Greet()
        {
            Console.WriteLine("Hi from ChildClass");
        }
    }

    public class GrandChildClass : ChildClass
    {
        public override void Greet()
        {
            base.Greet();
        }
    }
}
