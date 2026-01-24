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
