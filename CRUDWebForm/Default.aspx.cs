using CRUDClassLibrary.DataAccess;
using CRUDClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDWebForm
{
    public partial class _Default : Page
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        IDataAccess dataAccess = new DataAccessClass();
        StudentModel studentModel = new StudentModel();
        protected void Page_Load(object sender, EventArgs e)
        {
           Button1_Click(sender, e);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            List<StudentModel> list = new List<StudentModel>();
            list = dataAccess.DisplayStudentData(conn);
            GridView1.DataSource = list;
            GridView1.DataBind();
            
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            studentModel.StudentID = Convert.ToInt32(TextBox1.Text);
            //int id = Convert.ToInt32(TextBox1.Text);

            dataAccess.DeleteStudentData(studentModel, conn);
            Button1_Click(sender, e);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            studentModel.StudentID = Convert.ToInt32(TextBox2.Text);
            studentModel.StudentName = TextBox3.Text;
            dataAccess.UpdateStudentData(studentModel, conn);
            Button1_Click(sender, e);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            studentModel.StudentName = TextBox4.Text;
            dataAccess.InsertStudentData(studentModel, conn);

            Button1_Click(sender, e);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}