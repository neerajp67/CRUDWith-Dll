using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRUDClassLibrary.DataAccess;
using CRUDClassLibrary.Model;

namespace ConsoleCRUD
{
    class Program
    {
        
        static void Main()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
         
            IDataAccess dataAccess = new DataAccessClass();
            StudentModel studentModel = new StudentModel();
            Console.WriteLine("Select Operation To Perform: ");
            Console.Write("Press 1 to Read Data: ");
            Console.WriteLine();
            Console.Write("Press 2 to Create Data: ");
            Console.WriteLine();
            Console.Write("Press 3 to Update Data: ");
            Console.WriteLine();
            Console.Write("Press 4 to Delete Data: ");
            Console.WriteLine();
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    List<StudentModel> list = new List<StudentModel>();
                    list = dataAccess.DisplayStudentData(conn);
                    Console.WriteLine("Student Id \t Student Name");
                    foreach (var obj in list)
                    {
                        Console.WriteLine(obj.StudentID + "\t\t " + obj.StudentName);
                    }
                    break;
                case 2:
                    Console.Write("Enter New Student's Name: ");
                    string StudentName = Console.ReadLine();
                    studentModel.StudentName = StudentName;
                    Console.WriteLine();

                    dataAccess.InsertStudentData(studentModel, conn);

                    Console.WriteLine();
                    Console.WriteLine("Data Inserted Successfully..");
                    
                    break;

                case 3:
                    Console.Write("Enter Student's Id to Update Record: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter Student's New Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    studentModel.StudentID = id;
                    studentModel.StudentName = name;
                    dataAccess.UpdateStudentData(studentModel, conn);

                    Console.WriteLine();
                    Console.WriteLine("Record Updated Successfully..");
                    break;

                case 4:
                    Console.Write("Enter Student's Id to Delete Record: ");
                    int sId = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    studentModel.StudentID = sId;
                    dataAccess.DeleteStudentData(studentModel, conn);
                    Console.WriteLine("Record Deleted Successfully..");
                    break;

                default:
                    Console.WriteLine("Invalid Input! Please Try Again..");
                    break;
            }
            Main();
        }
    }
}
