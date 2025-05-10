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
    }


    public class ChildCls : ParentCls
    {

        #region From Childclass, Call ParentMathod
        public void FromChildCallParentMathod()
        {
            base.Test1();
            base.Test2();
        }
        #endregion
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

    }


}
