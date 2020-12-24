using CRUDClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUDClassLibrary.DataAccess
{
    public class DataAccessClass : IDataAccess
    {
        StudentModel stdModel = new StudentModel();
        public void DeleteStudentData(StudentModel studentModel, SqlConnection conn)
        {
            stdModel.StudentID = studentModel.StudentID;
            conn.Open();
            SqlCommand cm = new SqlCommand("Delete from StudentRecord where StudentId="+stdModel.StudentID, conn);
            cm.ExecuteNonQuery();
            conn.Close();
        }

        public List<StudentModel> DisplayStudentData(SqlConnection conn)
        {
            
            List<StudentModel> lst = new List<StudentModel>();
            conn.Open();

            SqlCommand command = new SqlCommand("Select * From StudentRecord", conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                lst.Add
                (
                    new StudentModel
                    {
                        StudentID = Convert.ToInt32(dr["StudentID"]),
                        StudentName = Convert.ToString(dr["StudentName"])
                    }
                );
            }
            conn.Close();
            return lst;
        } 

        public void InsertStudentData(StudentModel studentModel, SqlConnection conn)
        {
           
            conn.Open();
            stdModel.StudentName = studentModel.StudentName;
            SqlCommand cm = new SqlCommand("Insert Into StudentRecord Values(@StudentName)", conn);
            cm.Parameters.AddWithValue("@StudentName", stdModel.StudentName);
            cm.ExecuteNonQuery();
            conn.Close();
           
        }

        public void UpdateStudentData(StudentModel studentModel, SqlConnection conn)
        {
            stdModel.StudentID = studentModel.StudentID;
            stdModel.StudentName = studentModel.StudentName;
            conn.Open();
            SqlCommand cm = new SqlCommand("Update StudentRecord set StudentName='" + stdModel.StudentName + "' where StudentId=" + stdModel.StudentID, conn);
            cm.ExecuteNonQuery();
            conn.Close();
          
        }
    }

}
