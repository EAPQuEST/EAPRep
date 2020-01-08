using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Arrays
{
    class Matrix
    {
        int row;
        int coloumn;
        int[,] M;
       // public int i1, j1;

        public Matrix()
        {

        }

   



        public void ReadMatrix()
        {
           
            
            Console.WriteLine("Enter the number of rows");
            row= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of coloumn");
            coloumn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the array Elements");
            M = new int[row, coloumn];

            for(int  i1 = 0; i1 < row; i1++)
            {
                for(int  j1=0;j1<coloumn;j1++)
                {
                    M[i1, j1] = Convert.ToInt32(Console.ReadLine());
                }
            }

        }

      
        public void DisplayMatrix()
        {
            
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < coloumn; j++)
                {
                    Console.Write(M[i,j] +"\t");
                }
                Console.WriteLine();
            }
        }

        public void MatrixAddition(Matrix m1,Matrix m2)
        {
            row = m1.row;
            coloumn = m1.coloumn;
            M = new int[row, coloumn];
            for (int i = 0; i <row; i++)
            {
                for (int j = 0; j <coloumn; j++)
                {
                    M[i, j] =m1.M[i,j] + m2.M[i,j];
                }
            }

        }

        public void MatrixSubtraction(Matrix m1, Matrix m2)
        {
            row = m1.row;
            coloumn = m1.coloumn;
            M = new int[row, coloumn];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloumn; j++)
                {
                    M[i, j] = m1.M[i, j] - m2.M[i, j];
                }
            }

        }

        public static void Main()
        {
            Matrix M1 = new Matrix();
            Matrix M2 = new Matrix();

            Matrix M3 = new Matrix();
            Matrix M4 = new Matrix();




            Console.WriteLine("*****************Matrix 1*****************");
            M1.ReadMatrix();
           

            Console.WriteLine("*****************Matrix 2*****************");

            M2.ReadMatrix();


            Console.WriteLine("*****************Matrix 1*****************");

            M1.DisplayMatrix();

            Console.WriteLine("*****************Matrix 2*****************");
            M2.DisplayMatrix();

            Console.WriteLine("*****************Addition*****************");
            M3.MatrixAddition(M1,M2);
            M3.DisplayMatrix();

            Console.WriteLine("****************Subtraction*****************");
            M4.MatrixSubtraction(M1, M2);
            M4.DisplayMatrix();


            Console.ReadKey();


        }
    }
}
