using System;

namespace CodePractice.Opps
{
    public class ParentCls
    {
        public void Test1()
        {
            Console.WriteLine("From Parent class: Test 1()");
        }
        public virtual void Test2()
        {
            Console.WriteLine("From Parent class: Test 2()");
        }
        public virtual void Test5()
        {
            Console.WriteLine("From Parent class: Test 5(), " +
                "virtual but not overriden in child class");
        }
    }


    public class ChildCls : ParentCls
    {
        public new void Test1()
        {
            Console.WriteLine("From Child class: Test 1");
        }
        public override void Test2()
        {
            Console.WriteLine("From Child class: Test 2");
        }
        public void Test3()
        {
            Console.WriteLine("From Child class: Test 3");
        }
        public void FromChild_CallParentMathod()
        {
            base.Test1();
            base.Test2();
        }

    }


}
