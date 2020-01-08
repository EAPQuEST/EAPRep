using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Pattern
    {
        int n = 5;

        public void Pattern1()
        {
            int no, nos;
            for (no = 1; no <= n; ++no)
            {

                for (nos = 1; nos <= no; ++nos)
                {
                    Console.Write("* ");

                }
                Console.WriteLine("\n");
            }



        }

        public void Pattern2()
        {
            int no, nos;
            for (no = 1; no <= n; ++no)
            {

                for (nos = 1; nos <= no; ++nos)
                {
                    Console.Write("{0} ", nos);

                }
                Console.WriteLine("\n");
            }



        }
        public void Pattern3()

        {

            for (int no = 1; no <= n; no++)

            {



                for (int i = 1; i <= n - no; i++)

                {

                    Console.Write("  ");

                }



                for (int j = 1; j <= no; j++)

                {

                    Console.Write(" *");

                }



                Console.WriteLine("\n");

            }

        }
        public void Pattern4()

        {

            for (int no = 1; no <= n; no++)

            {



                int k = 0;

                for (int i = 1; i <= n - no; i++)

                {

                    Console.Write("  ");

                }



                for (int j = 1; j <= no; j++)

                {

                    Console.Write(" *");

                    k++;

                }



                for (; k > 1; k--)

                {

                    Console.Write(" *");

                }





                Console.WriteLine("\n");

            }





        }
        public void Pattern5()

        {

            for (int no = 1; no <= n; no++)

            {

                if (no == 1 || no == n)

                {

                    for (int i = 1; i <= n; i++)

                    {

                        Console.Write(" * ");

                    }

                }

                else

                {

                    for (int j = 1; j <= n; j++)

                    {

                        if (j == 1 || j == n)

                        {

                            Console.Write(" * ");

                        }

                        else

                        {

                            Console.Write("   ");

                        }





                    }

                }



                Console.WriteLine("\n");

            }

        }
        public void Pattern6()

        {

            for (int no = n; no >= 1; no--)

            {



                int k = 0;

                for (int i = n - no; i >= 1; i--)

                {

                    Console.Write("  ");

                }



                for (int j = no; j >= 1; j--)

                {

                    Console.Write(" *");

                    k++;

                }



                for (; k > 1; k--)

                {

                    Console.Write(" *");

                }

                Console.WriteLine("\n");

            }

        }
        public void Pattern7()

        {

            for (int no = n; no >= 1; no--)

            {



                int k = 0;

                for (int i = n - no; i >= 1; i--)

                {

                    Console.Write("  ");

                }



                for (int j = no; j >= 1; j--)

                {

                    Console.Write(" *");

                    k++;

                }



                for (; k > 1; k--)

                {

                    Console.Write(" *");

                }

                Console.WriteLine("\n");

            }

        }



        public void print1()

        {

            for (int no = 1; no < n; no++)

            {



                int k = 0;

                for (int i = 1; i <= n - no; i++)

                {

                    Console.Write("  ");

                }



                for (int j = 1; j <= no; j++)

                {

                    Console.Write(" *");

                    k++;

                }



                for (; k > 1; k--)

                {

                    Console.Write(" *");

                }

                Console.WriteLine("\n");

            }

        }




        public static void Main(string[] args)
        {
            Pattern objpat1 = new Pattern();

            objpat1.Pattern1();
            objpat1.Pattern2();
            objpat1.Pattern3();
            objpat1.Pattern4();
            objpat1.Pattern5();
            objpat1.Pattern6();
            objpat1.Pattern7();
            objpat1.print1();
            Console.ReadKey();

        }
    }
}
