using LMS_Project2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace LMS_Project2.Controllers
{
    public class AdminloginController : Controller
    {
        private readonly IConfiguration _configuration;
        public AdminloginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("admlogin")]
        public IActionResult admin_login(Admin admin)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("LMS").ToString());
            List<Admin> list= new List<Admin>();
            //SqlConnection sqlConn = new SqlConnection(con);
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("LMS_Adminlogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            foreach(DataRow row in dt.Rows)
            {
                Admin adm =new Admin();
                adm.Admin_Email = (string)row["Admin_Name"];
                adm.Admin_Password = (string)row["Admin_Password"];
                list.Add(admin);
            }
           // return new admlogin(list);
            var data = list.Where(s => s.Admin_Email == admin.Admin_Email && s.Admin_Password == admin.Admin_Password).Count();
            if (data < 0)
            {
                return Content("valid data");
            }
            else
            {
                return Content("Invalid data");
            }
        }

            [HttpPost]
            [Route("admregistration")]
            public IActionResult Admin_registration(Admin admin)
            {
                String Result = "";
                SqlConnection con = new SqlConnection(_configuration.GetConnectionString("LMS").ToString());
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("LMS_Intern", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Admin_Name", admin.Admin_Name);
                    cmd.Parameters.AddWithValue("@Admin_Email", admin.Admin_Email);
                    cmd.Parameters.AddWithValue("@Admin_Password", admin.Admin_Password);
                    Result = (string)cmd.ExecuteScalar();
                }
                return Ok(Result);
            }
    }
}
