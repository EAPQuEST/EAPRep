using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using cs_Week5.dto;
using cs_Week5.dao;
using System.Data;
using cs_Week5.Helper;


namespace cs_Week5.bl
{
    class StudentMarkBl
    {
        public static int StudentMarkInsert(StudentMark studentMark)
        {
            int output = 0;

            try
            {
                studentMark.Total = studentMark.Mark1 + studentMark.Mark2 + studentMark.Mark3;
                if (studentMark.Mark1 < 50 || studentMark.Mark2 < 50 || studentMark.Mark3 < 50)
                {
                    studentMark.Result = "Fail";
                }
                else
                {
                    studentMark.Result = "Pass";
                }
                output = StudentMarkDao.StudentMarkInsert(studentMark);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkBl.cs:StudentMarkInsert", ex.Message.ToString());
            }



            return output;
        }
        public static DataSet GetStudentIds()
        {
            string sql = "";

            DataSet dsStudents = null;

            try
            {
                dsStudents = StudentMarkDao.GetStudentIds();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkBl.cs:GetStudentIds", ex.Message.ToString());
            }

            return dsStudents;
        }
        public static DataSet GetStudents()
        {
            string sql = "";

            DataSet dsStudents = null;

            try
            {
                dsStudents = StudentMarkDao.GetStudents();
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkBl.cs:GetStudents", ex.Message.ToString());
            }

            return dsStudents;
        }
        public static StudentMark GetStudentById(string studentId)
        {

            StudentMark studentMark = null;

            try
            {
                studentMark = StudentMarkDao.GetStudentById(studentId);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkBl.cs:GetStudentByID", ex.Message.ToString());
            }

            return studentMark;
        }
        public static int StudentMarkDelete(String studentId)
        {
            int output = 0;


            try
            {


                output = StudentMarkDao.StudentMarkDelete(studentId);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkBl.cs:StudentMarkDelete", ex.Message.ToString());
            }



            return output;
        }
        public static int StudentMarkUpdate(StudentMark studentMark)
        {
            int output = 0;


            try
            {
                studentMark.Total = studentMark.Mark1 + studentMark.Mark2 + studentMark.Mark3;
                if (studentMark.Mark1 < 50 || studentMark.Mark2 < 50 || studentMark.Mark3 < 50)
                {
                    studentMark.Result = "Fail";
                }
                else
                {
                    studentMark.Result = "Pass";
                }



                output = StudentMarkDao.StudentMarkUpdate(studentMark);


            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkBl.cs:StudentMarkDelete", ex.Message.ToString());
            }



            return output;
        }
        public static string GetNewStudentId()
        {

            string lastStudentId = null;
            string newStudentId = null;

            try
            {


                lastStudentId = StudentMarkDao.GetLastStudentId();
                if(lastStudentId != null)
                {
                    newStudentId = UtilityHelper.GenerateID(lastStudentId);
                }
                else
                {
                    newStudentId = "STU101";
                }



            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkBl.cs:GetLastStudentId()", ex.Message.ToString());
            }

            return newStudentId;
        }
        public static DataSet GetStudentsLike(string likeName)
        {
            
            DataSet dsStudents = null;

            try
            {
                dsStudents = StudentMarkDao.GetStudentsLike(likeName);

            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("*** Error : StudentMarkBl.cs:GetStudentsLike()", ex.Message.ToString());
            }
           
            return dsStudents;
        }
    }
}
