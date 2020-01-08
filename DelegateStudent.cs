using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Delegates
{
    public delegate bool IsPromotableStudent(Student student);

    class DelegateStudent
    {
        public static void Main()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student { ID = 101, Name = "Gopu", Mark = 40, Mark1 = 40 });
            studentList.Add(new Student { ID = 102, Name = "shasna", Mark = 50 ,Mark1 = 50});
            studentList.Add(new Student { ID = 103, Name = "Aiswarya", Mark = 60, Mark1 = 60 });
            studentList.Add(new Student { ID = 104, Name = "Archana", Mark = 30, Mark1 = 30 });
            studentList.Add(new Student { ID = 105, Name = "Anandu", Mark = 40, Mark1 = 40 });
            studentList.Add(new Student { ID = 106, Name = "Swetha", Mark = 70, Mark1 = 70 });

            Console.WriteLine("List of Students Promoted");
            

            IsPromotableStudent isPromotableDelegate = new IsPromotableStudent(IsPromotable);
            Student.GetPromotedList(studentList, isPromotableDelegate);

            Console.ReadLine();

        }
        public static bool IsPromotable(Student students)
        {
            bool eligible = false;
            if (students.Mark > 40 && students.Mark1 > 40)
            {
                eligible = true;
            }
            return eligible;
        }
    }
    

        


    
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Mark { get; set; }
        public int Mark1 { get; set; }
       


        
        public static void GetPromotedList(List<Student> students, IsPromotableStudent isPromotableDelegate)
        {
            foreach (Student student in students)
            {
                if (isPromotableDelegate(student))
                {
                    Console.WriteLine("Student Id {0}", student.ID);
                    Console.WriteLine("Name {0}", student.Name);
                    Console.WriteLine("Mark1 {0}", student.Mark);
                    Console.WriteLine("Mark2 {0}", student.Mark1);
                    Console.WriteLine("Total Marks {0}", student.Mark1+student.Mark);


                    Console.WriteLine("**********************");
                }


            }
        }
    }
}
