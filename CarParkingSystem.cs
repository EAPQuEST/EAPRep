using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Arrays
{
    class CarParkingSystem
    {
    
        int[] slot = new int[10] {0,0,0,0,0,0,0,0,0,0};
        int space;

        public void Park()
        {
            int i = 0;
            bool flag = true;
            for(i=0;i<slot.Length;i++)
            {
               
                if (slot[i] == 0)
                {
                    slot[i] = 1;
                    Console.WriteLine("Your car is parked in slot {0}", i);
                    flag = false;
                  
                    break;
                }

            } 
            if(flag)
            {
                Console.WriteLine("Sorry no slot Available for Parking");

            }
        }

        public void UnPark()
        {
            
            Console.WriteLine("Enter your slot");
            space=Convert.ToInt32(Console.ReadLine());
            int i = space;
            if (slot[i] == 1)
            {
                slot[space] = 0;
                Console.WriteLine("Thank You for parking");

            }
            else
            {
                Console.WriteLine("No car available in the slot");
            }

            
        }

        public void View()
        {
            for(int i = 0; i < slot.Length; i++)
            {
                
               
                    Console.WriteLine("Slot{0}:{1}",i,slot[i]);
                
                
               

            }
        }

        public static void Main()
        {
           

            CarParkingSystem p = new CarParkingSystem();

            int option;
                do
                {
                    Console.WriteLine("*****************************");
                    Console.WriteLine("1.Park The Car");
                    Console.WriteLine("2.Unpark");
                    Console.WriteLine("3.View");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine("*****************************");
                    Console.WriteLine("Enter the option (1-4)");
                    option = Convert.ToInt32(Console.ReadLine());


                    switch (option)
                    {
                        case 1:
                           //CarParkingSystem p = new CarParkingSystem();

                            p.Park();

                            break;

                        case 2:
                           // CarParkingSystem p = new CarParkingSystem();
                            p.UnPark();
                            break;

                        case 3:
                           // CarParkingSystem p3 = new CarParkingSystem();
                            p.View();
                            break;

                        case 4:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Wrong option,please enter 1-4");
                            break;



                    }


                } while (true);
            


        }

    }
}
