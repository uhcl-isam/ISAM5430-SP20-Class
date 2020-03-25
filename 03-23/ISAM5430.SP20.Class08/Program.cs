using System;

namespace ISAM5430.SP20.Class08
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class date.
            Date date = new Date();
            //date.Month = 3;
            //date.Day = 23;
            //date.Year = 2020;
            Console.WriteLine(date.Month + "/" + date.Day);
            Console.WriteLine(date.ToMonthDay());
            Console.WriteLine(date);
            Console.WriteLine();
            Console.WriteLine();

            // how do you set a Date object 8/22/2014
            Date hireDate = new Date(8, 22, 2014);
            Employee emp = new Employee(1234567, "Michael", "W", hireDate);

            Console.WriteLine(emp);
            emp.HireDate.Year = 1999;
            Console.WriteLine(emp.HireDate);
        }
    }
}
