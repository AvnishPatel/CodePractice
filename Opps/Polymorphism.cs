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

    #region Hierarchical inheritance
    class Human
    {
        public virtual void Hello() { Console.WriteLine("Hello Human!"); }
    }
    class Man : Human
    {
        public override void Hello() { Console.WriteLine("Hello Man!"); }
    }
    class Woman : Man
    {
        public new void Hello() { Console.WriteLine("Hello Woman!"); }
    }
    #endregion

    #region Hierarchical inheritance
    class Employee
    {
        public virtual int CalculateRewards(int numberOfItemPurchased) 
        {
            return numberOfItemPurchased * 10; 
        }
    }
    class PriviledgeEmployee : Employee
    {
        public static int CalculateRewards(int numberOfItemPurchased) 
        { 
            return numberOfItemPurchased * 20; 
        }
    }

    class VIPEmployee : Employee
    {
        public new int CalculateRewards(int numberOfItemPurchased)
        {
            return numberOfItemPurchased * 20;
        }
    }
    #endregion

}
