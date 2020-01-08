using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Delegates
{
    public delegate bool IsPromotableDelegate(Employee1 employee);

    class EmployeePromotion
    {
        public static void Main()
        {
            List<Employee1> employeeList1 = new List<Employee1>();
            employeeList1.Add(new Employee1 { ID = 101, Name = "Gopu", Salary = 4000, Experance = 4 });
            employeeList1.Add(new Employee1 { ID = 102, Name = "shasna", Salary = 5000, Experance = 5 });
            employeeList1.Add(new Employee1 { ID = 103, Name = "Aiswarya", Salary = 6000, Experance = 6 });
            employeeList1.Add(new Employee1 { ID = 104, Name = "Archana", Salary = 3000, Experance = 3 });
            employeeList1.Add(new Employee1 { ID = 105, Name = "Anandu", Salary = 4000, Experance = 4 });
            employeeList1.Add(new Employee1 { ID = 106, Name = "Swetha", Salary = 7000, Experance = 7 });

            Console.WriteLine("List of Employees Eligible for Promotion");
           //Employee1.GetPromotedList(employeeList1);
           

            IsPromotableDelegate isPromotableDelegate = new IsPromotableDelegate(IsPromotable);
            Employee1.GetPromotedList(employeeList1, isPromotableDelegate);

            Console.ReadLine();

        }
        public static bool IsPromotable(Employee1 employee)
        {
            bool eligible = false;
            if (employee.Experance >= 4 && employee.Salary < 5000)
            {
                eligible = true;
            }
            return eligible;
        }
    }

    public class Employee1
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Experance { get; set; }
        public int Salary { get; set; }

        public static void GetPromotedList(List<Employee1> employees)
        {
            foreach (Employee1 employee in employees)
            {
                if (employee.Experance >= 5)
                {
                    Console.WriteLine("Employee Id {0}", employee.ID);
                    Console.WriteLine("Name {0}", employee.Name);
                    Console.WriteLine("Salary {0}", employee.Salary);
                    Console.WriteLine("Experiance {0}", employee.Experance);
                    Console.WriteLine("**********************");
                }
            }
        }
        public static void GetPromotedList(List<Employee1> employees, IsPromotableDelegate isPromotableDelegate)
        {
            foreach(Employee1 employee in employees)
            {
                if (isPromotableDelegate(employee))
                {
                    Console.WriteLine("Employee Id {0}", employee.ID);
                    Console.WriteLine("Name {0}", employee.Name);
                    Console.WriteLine("Salary {0}", employee.Salary);
                    Console.WriteLine("Experiance {0}", employee.Experance);
                    Console.WriteLine("**********************");
                }


            }
        }
    }
}

