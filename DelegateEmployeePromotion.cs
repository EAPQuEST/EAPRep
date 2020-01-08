using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Delegates
{
    class DelegateEmployeePromotion
    {
        public static void Main()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee { ID = 101, Name = "Gopu" ,Salary=4000,Experance=4});
            employeeList.Add(new Employee { ID = 102, Name = "shasna", Salary = 5000, Experance = 5 });
            employeeList.Add(new Employee { ID = 103, Name = "Aiswarya", Salary = 6000, Experance = 6 });
            employeeList.Add(new Employee { ID = 104, Name = "Archana", Salary = 3000, Experance = 3 });
            employeeList.Add(new Employee { ID = 105, Name = "Anandu", Salary = 4000, Experance = 4 });
            employeeList.Add(new Employee { ID = 106, Name = "Swetha", Salary = 7000, Experance = 7 });

            Console.WriteLine("List of Employees Eligible for Promotion");
            Employee.GetPromotedList(employeeList);
            Console.ReadLine();


        }
    }

    class Employee
    {
        public int ID { get;set; }
        public string Name { get; set; }
        public int Experance { get; set; }
        public int Salary { get; set; }

        public static void GetPromotedList(List<Employee> employees)
        {
            foreach (Employee employee in employees)
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
    }
}
