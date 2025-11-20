using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    public class Generic<T>
    {
        public List<T> ReturnListOfAnyDatatype(T a, T b, T c)
        {
            List<T> MyList = new List<T>();
            MyList.Add(a);
            MyList.Add(b);
            MyList.Add(c);
            return MyList;
        }
    }
}
