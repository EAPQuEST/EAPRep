using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Strings
{
    class Employee
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number of employess");
            number = Convert.ToInt32(Console.ReadLine());

            Employee1[] e = new Employee1[number];

            Console.WriteLine("Enter the Employee Details");
            for (int i = 0; i < e.Length; i++)
            {
                Console.WriteLine("Enter the Employee {0} Details", (i + 1));
                e[i] = new Employee1();
                e[i].ReadEmployee();
                e[i].HRA();
                e[i].DA();
                e[i].PF();
                e[i].NetSalary();
            }

            Console.WriteLine("Enter the Employee Details");
            
            for (int i = 0; i < e.Length; i++)
            {
                Console.WriteLine(e[i].ToString());
              


            }
            Console.ReadKey();
        }
    }
    class Employee1
    {
        int id;
        string name;
        double basicPay;
        double hra,pf,dA,netSalary;

        public Employee1()
        {

        }

        public Employee1(int id ,string name,double basicPay)
        {
            this.id = id;
            this.name = name;
            this.basicPay = basicPay;
        }

        public void ReadEmployee()
        {
            Console.WriteLine("Enter the Name");
            name = (Console.ReadLine());
            Console.WriteLine("Enter the id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            basicPay = Convert.ToInt32(Console.ReadLine());



        }

        public void HRA()
        {
            
            hra = basicPay * 0.1;
          
        }

        public void PF()
        {
           
            pf = basicPay * 0.12;
          
        }

        public void DA()
        {
            
            dA = basicPay * 0.05;
           
        }

        public void NetSalary()
        {
            netSalary = basicPay + hra + dA - pf;
           
        }

        public override string ToString()
        {
            String output = "";
            output = "********************************"+"\n";
            output += "Employee ID: "+id+ "\n";
            output += "Employee Name: "+name+ "\n";
            output += "Basic Pay: "+basicPay+ "\n";
            output += "HRA: "+hra+ "\n";
            output += "DA: "+dA+ "\n";
            output += "PF: "+pf+ "\n";
            output += "***********************************";

            return output;
        }

    }
}
