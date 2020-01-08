using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Distance
    {
        int feet, inches;

        public Distance()
        {

        }

        public Distance(int feet, int inches)
        {
            this.feet = feet;
            this.inches = inches;
        }

        public void DisplayDistance()
        {
            Console.WriteLine("Feet:{0} inches:{1}", feet, inches);
        }

        public void ReadDistance()
        {
            Console.WriteLine("Enter the value of feet:");
            feet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of inches:");
            inches = Convert.ToInt32(Console.ReadLine());
        }

        public void AddDistance(Distance objDistance1, Distance objDistance2)
        {
            feet = objDistance1.feet + objDistance2.feet;
            inches = objDistance1.inches + objDistance2.inches;

            if (inches >= 12)
            {
                feet++;
                inches %= 12;
            }
        }

        public void SubDistance(Distance objDistance1, Distance objDistance2)
        {
            int feet1, feet2,feet3;

            feet1 = (objDistance1.feet * 12)+ objDistance1.inches;
            feet2 = (objDistance2.feet * 12)+ objDistance2.inches;

            if (feet1 > feet2)
            {

                
                feet3 = feet1 - feet2;
                feet = feet3 / 12;
                inches = feet3%12;

                
            }

            else
            {
                feet3 = feet2 - feet1;

                feet = feet3 / 12;
                inches = feet3 % 12;
            }
            
       
            
        }

        public static void Main()
        {
            Distance distance1 = new Distance();
            Distance distance2 = new Distance();
            Distance distance3 = new Distance();
            Distance distance4 = new Distance();
            Distance distance5 = new Distance();
            Distance distance6 = new Distance();
            

            Console.WriteLine("Enter the value for distance 1");
            distance1.ReadDistance();
            Console.WriteLine("Enter the value for distance 2");
            distance2.ReadDistance();


            distance3.AddDistance(distance1, distance2);
            //distance3.SubDistance(distance1, distance2);

            Console.WriteLine("Distance1: ");
            distance1.DisplayDistance();

            Console.WriteLine("Distance2: ");
            distance2.DisplayDistance();

            Console.WriteLine("Distance3: ");
            distance3.DisplayDistance();

            distance4 = distance1.AddDistance(distance2);
            Console.WriteLine("Distance4: ");
            distance4.DisplayDistance();

            distance5 = distance1 + distance2;
            Console.WriteLine("Distance5: ");
            distance5.DisplayDistance();

            Console.WriteLine("********************Subtraction**************** ");

            Console.WriteLine("Distance1: ");
            distance1.DisplayDistance();

            Console.WriteLine("Distance2: ");
            distance2.DisplayDistance();

            distance6.SubDistance(distance1, distance2);

            Console.WriteLine("Distance6: ");
            distance6.DisplayDistance();

        



            Console.ReadKey();
        }

        public static Distance operator +(Distance d1, Distance d2)
        {
            Distance d = new Distance();

            d.feet = d1.feet + d2.feet;
            d.inches = d1.inches + d2.inches;

            if (d1.inches >= 12)
            {
                d1.feet++;
                d1.inches %= 12;
            }

            return d;
        }

        private Distance AddDistance(Distance distance2)
        {
            Distance d1 = new Distance();

            d1.feet = feet + distance2.feet;
            d1.inches = inches + distance2.inches;

            if (d1.inches >= 12)
            {
                d1.feet++;
                d1.inches %= 12;
            }

            return d1;

        }

        






    }
}
