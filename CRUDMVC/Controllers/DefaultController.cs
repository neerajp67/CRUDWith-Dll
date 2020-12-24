using CRUDClassLibrary.DataAccess;
using CRUDClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;

namespace CRUDMVC.Controllers
{
    public class DefaultController : Controller
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        // GET: Default
        public ActionResult Create(StudentModel studentModel)
        {
            IDataAccess dataAccess = new DataAccessClass();

            //StudentModel stdModal = new StudentModel();

            //string name = "From MVC";
           string name= studentModel.StudentName;

            dataAccess.InsertStudentData(name, conn);

            return RedirectToAction("Index");
            
        }
    }
}