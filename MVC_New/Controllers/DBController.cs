using CRUDClassLibrary.DataAccess;
using CRUDClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_New.Controllers
{
    public class DBController : Controller
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        List<StudentModel> list1 = new List<StudentModel>();
        IDataAccess dataAccess = new DataAccessClass();
        // GET: DB
        public ActionResult Index()
        {
            
            List<StudentModel> list = new List<StudentModel>();
            list = dataAccess.DisplayStudentData(conn);
            return View(list);
            
        }
        [HttpGet]
        public ActionResult Create()
        { 
            return View(new StudentModel());
        }
        [HttpPost]
        public ActionResult Create(StudentModel studentModel)
        {
            //string name = formColl["StudentName"];
            //StudentModel studentModel = new StudentModel 
            //{
            //    StudentName = name
            //};
           dataAccess.InsertStudentData(studentModel, conn);
            
            return RedirectToAction("Index");
        }
        public ActionResult Delete()
        {
            return View(new StudentModel());
        }
        [HttpPost]
        public ActionResult Delete(StudentModel studentModel)
        {
            //int id = Convert.ToInt32(formColl["StudentId"]);
            //StudentModel studentModel = new StudentModel
            //{
            //    StudentID = id
            //};
            dataAccess.DeleteStudentData(studentModel, conn);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update()
        {
            return View(new StudentModel());
        }
        [HttpPost]
        public ActionResult Update(StudentModel studentModel)
        {
            //string name = formColl["StudentName"];
            //StudentModel studentModel = new StudentModel
            //{
            //    StudentName = name
            //};
            dataAccess.UpdateStudentData(studentModel, conn);

            return RedirectToAction("Index");
        }
    }
}