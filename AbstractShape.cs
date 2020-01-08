using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class AbstractShape
    {
        double area;

        public static void Main()
        {
            Square shape1 = new Square();
            Triangle shape2 = new Triangle();
            Circle1 shape3 = new Circle1();
            //AbstractShape shape2 = new AbstractShape();
            //AbstractShape shape3 = new AbstractShape();
            Console.WriteLine("Square");

            shape1.ReadData();
            
            shape1.FindArea();
            shape1.Display();
            
            Console.WriteLine("Triangle");
            shape2.ReadData();

            shape2.FindArea();
            shape2.Display();

            Console.WriteLine("Circle");
            shape3.ReadData();

            shape3.FindArea();
            shape3.Display();

            Console.ReadKey();
        }

       
    }

    abstract class Shape
    {
        const double PI = 3.14;
        double area;
        
        public void Display()
        {
            Console.WriteLine("Area is {0}",area);
        }

        abstract public void FindArea();
    }

    class Square:Shape
    {
        double side;
        double area;

        public Square()
        {

        }

        public Square(double side)
        {
            this.side = side;
        }

        public void ReadData()
        {
            Console.WriteLine("Enter the value of side:");
            side = Convert.ToInt32(Console.ReadLine());
           
        }

        public override void FindArea()
        {
            area = side * side;
        }

        public  void Display()
        {
            Console.WriteLine("The area is {0}", area);

        }
    }

    class Triangle : Shape
    {
        double side;
        double height;
        double area;

        public Triangle()
        {

        }

        public Triangle(double side,double height)
        {
            this.side = side;
            this.height = height;
        }

        public void ReadData()
        {
            Console.WriteLine("Enter the value of base:");
            side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of height:");
            height = Convert.ToInt32(Console.ReadLine());

        }

        public override void FindArea()
        {
            area = (side * height)/2;
        }

        public  void Display()
        {
            Console.WriteLine("The area is {0}", area);

        }
    }

    class Circle1 : Shape
    {
        double radius;
        double area;
        const double PI = 3.14;

        public Circle1()
        {

        }

        public Circle1(double radius)
        {
            this.radius = radius;
            
        }

        public void ReadData()
        {
            Console.WriteLine("Enter the value of radius:");
            radius = Convert.ToInt32(Console.ReadLine());

        }

        public override void FindArea()
        {
            area = PI*radius*radius;
        }

        public  void Display()
        {
            Console.WriteLine("The area is {0}", area);

        }
    }





}
