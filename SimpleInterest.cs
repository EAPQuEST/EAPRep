using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class SimpleInterest
    {
        double principle;
        double interestRate;
        double time;
        double simpleInterest;
        double compoundInterest;
        double amount;
        double n;

        public void ReadData()
        {
            Console.WriteLine("Enter the Amount");
            principle= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the InterestRate");
            interestRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Time");
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of compound");
            n= Convert.ToInt32(Console.ReadLine());
        }

        public double FindSimple()
        {
            double R;
            R = interestRate / 100;
            double T;
            T = time / 12;
            simpleInterest = principle * R * T;


            return simpleInterest;



        }

        public void  FindCompound()
        {
            double R;
            R = interestRate / 100;
            double T;
            T = time / 12;
            double s;
            s = n * T;

            compoundInterest = principle * Math.Pow((1 + (R / T)),s);

        }

        public void DisplayData()
        {
            double result=FindSimple();
            amount = principle + result;

            Console.WriteLine("Simple Interest for {0} is {1}",principle, result);
            Console.WriteLine("Total Amount will be for {0}", amount);
            Console.WriteLine("Compound Interest for {0} is {1}", principle, compoundInterest);
        }

        public static void Main()
        {
           SimpleInterest objSI = new SimpleInterest();

            objSI.ReadData();
            objSI.FindSimple();
            objSI.FindCompound();
            objSI.DisplayData();


            Console.ReadKey();
        }




    }
}
