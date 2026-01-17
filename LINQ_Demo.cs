using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodePractice
{

    public class ItemDetails
    {
        public string ItemName { get; set; }
        public int Price { get; set; }
    }
    public static class LINQ_Demo
    {
        public static void ReadDataFromTxtFile()
        {
            var itemDetails = from details in File.ReadAllLines(@"C:\Users\Avnish\source\repos\CodePractice\ItemDetailForLINQ.txt")
                              let parts = details.Split(":")
                              select new ItemDetails
                              {
                                  ItemName = parts[0],
                                  Price = Convert.ToInt32(parts[1])
                              };

            foreach (var item in itemDetails)

                if (item.ItemName == "")
                    break;
                else
                    Console.WriteLine("Name:" + item.ItemName + "\t" + "Price :" + item.Price);
        }

        public static void SimpleQuery()
        {
            List<Employee> empList = Employee.GetStudents();
            //var empQuery = from emp in empList
            //               where emp.Score > 60
            //               orderby emp.Name ascending
            //               select emp;

            //var empQuery = from emp in empList
            //               select new { emp.Name, emp.Score };

            var empQuery = empList.Select(emp => new { emp.Name, emp.Score });


            foreach (var item in empQuery)
            {
                Console.WriteLine("Name: {0}, Score: {1}", item.Name, item.Score);
            }
        }

        public static void SelectManyDemo()
        {
            List<Employee> employees = Employee.GetStudents();
            var programmingLangs = employees.SelectMany(emp => emp.Programming);

            Console.WriteLine("Programming Languages known by Employees:");
            foreach (var lang in programmingLangs)
            {
                Console.WriteLine(lang);
            }
        }


        public class Employee
        {
            public int EmpId { get; set; }
            public string Name { get; set; }
            public int Score { get; set; }
            public string Email { get; set; }
            public List<string> Programming { get; set; }

            public static List<Employee> GetStudents()
            {
                return new List<Employee>()
                {
                    new Employee(){EmpId = 1, Name = "James", Score=88, Email = "James@j.com", Programming = new List<string>() { "C#", "Jave", "C++"} },
                    new Employee(){EmpId = 2, Name = "Sam",   Score=98,  Email = "Sara@j.com", Programming = new List<string>() { "WCF", "SQL Server", "C#" }},
                    new Employee(){EmpId = 3, Name = "Patrik",Score=58, Email = "Patrik@j.com", Programming = new List<string>() { "MVC", "Jave", "LINQ"} },
                    new Employee(){EmpId = 4, Name = "Sara", Score=50, Email = "Sara@j.com", Programming = new List<string>() { "ADO.NET", "C#", "LINQ" } }
                };
            }
        }
    }

}
