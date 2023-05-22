using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using LMS_Project2.Models;
namespace LMS_Project2.Controllers
{
    public class StudentloginController : Controller
    {
        private readonly IConfiguration _configuration;
        public StudentloginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Slogin")]
        public string Slogin(Registration registration)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("LMS").ToString());
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student WHERE Email = '" + registration.Student_Email + "' AND Password = '" + registration.Student_Password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter("LMS_Studentlogin", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return "Valid User";
            }
            else
            {
                return "Invalid User";
            }
        }
    }
}
