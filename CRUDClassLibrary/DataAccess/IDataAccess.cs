using CRUDClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDClassLibrary.Model;

namespace CRUDClassLibrary.DataAccess
{
   public interface IDataAccess
    {
        void InsertStudentData(StudentModel studentModel, SqlConnection conn);
        void DeleteStudentData(StudentModel studentModel, SqlConnection conn);
        void UpdateStudentData(StudentModel studentModel, SqlConnection conn);
        List<StudentModel> DisplayStudentData(SqlConnection conn);
       
    }
}
