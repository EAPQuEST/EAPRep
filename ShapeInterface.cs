using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class ShapeInterface
    {
        public static void Main()
        {
            ShapeInterface c1 = new ShapeInterface();
            //c1.FindArea1();
        }
    }

    interface Square1
    {
        
       
        void FindArea();
    }

    interface Triangle1
    {
        void FindArea();
    }

    interface Circle2
    {
        
        void FindArea();
    }

    //class SubArea:Square1,Triangle1,Circle2
    //{
    //    public void FindArea1()
    //    {
            
    //        double area;
    //        double radius;
    //        Console.WriteLine("Emter the radius");
    //        radius= Convert.ToInt32(Console.ReadLine());
    //        area = 3.14 * radius * radius;
            
    //    }
    //}
}
