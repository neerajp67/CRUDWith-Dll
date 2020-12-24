using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDClassLibrary;
using CRUDClassLibrary.DataAccess;
using CRUDClassLibrary.Model;

namespace CRUDMVC.Controllers
{
    public class HomeController : Controller
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        List<StudentModel> list1 = new List<StudentModel>();
        public ActionResult Index()
        {

            IDataAccess dataAccess = new DataAccessClass();
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
        public ActionResult Create( FormCollection formColl)
        {
            string name = formColl["Name"];
            StudentModel studentModel = new StudentModel
            {
                StudentName = name
            };
            
            list1.Add(studentModel);
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}