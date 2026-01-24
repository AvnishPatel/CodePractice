using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Opps
{
    /// The reference variable, though points to derived class object, can identify only:
    /// · public properties and public non-virtual methods from base class

    /// · public virtual method(s) from base class, if overridden methods from its
    ///   derived class is NOT available

    /// · public overridden method(s), if available from derived class


    public class BaseClassA
    {
        public void NonVirtualMethod()
        { Console.WriteLine("NonVirtualMethod of Base class A"); }

        public virtual void Virtual_NonOverriddenMthod()
        { Console.WriteLine("Virtual and Non Overridden of Base class A"); }

        // Virtual method to be overridden in derived class
        public virtual void Show()
        { Console.WriteLine("From Class A"); }
    }
    public class B : BaseClassA
    {
        public override void Show()
        { 
            Console.WriteLine("public overriden() in derived class B"); }
    }
    public class C : B
    {
        public new void Show()
        { Console.WriteLine("From Class C"); }
    }

    #region inheritance + protected

    // public static void main(){
    //     Musician musician = new Musician();
    //     musician.DisplayAge();  // Output: Musician Age: 10
    // }
    public class Artist
    {
        protected int age = 10;
         
    }

    class Musician : Artist
    {
        public void DisplayAge()
        {
            Console.WriteLine("Musician Age: " + age);
        }
    }
    #endregion

}
