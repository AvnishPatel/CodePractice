using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{

    #region 200 : Object reference
    //public class Car
    //{
    //    public string Name { get; set; }
    //} 
    #endregion

    #region 100 : static constructor and static property
    //public class ClassRoom
    //{
    //    public static int NoOfComputer;
    //    static ClassRoom()
    //    {
    //        NoOfComputer = 100;
    //        Console.WriteLine("Computer set up complete");
    //    }
    //    public ClassRoom()
    //    {
    //        Console.WriteLine("Classroom set up complete");
    //    }
    //} 
    #endregion

    //public class Employee
    //{
    //    public static int salary = 10000;
    //}
    //class Manager : Employee
    //{
    //    public Manager()
    //    {
    //        salary = 30000;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Manager mgrObj = new Manager();
    //        Console.WriteLine("Employee Salary:" + Employee.salary);
    //        Console.WriteLine("Manager Salary : " + Manager.salary);
    //    }
    //}

    #region 101 : Class and Interface with static
    //interface IEmployee
    //{
    //    int GetSalary();

    //    void SalaryIncrement(int amount);
    //}

    //public class SoftwareEngineer : IEmployee
    //{
    //    private int salary;
    //    public SoftwareEngineer(int salary)
    //    {
    //        this.salary = salary;
    //    }
    //    public int GetSalary()
    //    {
    //        return salary;
    //    }
    //    public void SalaryIncrement(int amount)
    //    {
    //        salary += amount;
    //    }
    //} 
    #endregion


    #region 102 : getter setter access modifier
    //public class Employee
    //{
    //    private int salary;
    //    public int Salary
    //    {
    //        private get
    //        {
    //            return salary;
    //        }

    //        set
    //        {
    //            salary = value;
    //        }
    //    }

    //    public Employee(int salary)
    //    {
    //        this.Salary = salary;
    //    }
    //}
    #endregion

    #region 103 : getter setter and Abs
    //public class StudentAbs
    //{
    //    private int id;
    //    public int ID
    //    {
    //        get { return id; }
    //        set { id = Math.Abs(value); }
    //    }

    //    public StudentAbs(int _id)
    //    {
    //        ID = _id;
    //        Console.WriteLine("id : " + id);
    //        Console.WriteLine("ID : " + ID);
    //    }
    //} 
    #endregion

    #region 201 : Abstraction demo
    //public abstract class Vehicle
    //{
    //    public abstract void Start();
    //    public void Stop()
    //    {
    //        Console.WriteLine("Stopped");
    //    }
    //}

    //public class Car : Vehicle
    //{
    //    public override void Start()
    //    {
    //        Console.WriteLine("Car Started");
    //    }
    //} 
    #endregion
}
