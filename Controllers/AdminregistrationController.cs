using LMS_Project2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace LMS_Project2.Controllers
{
    public class AdminregistrationController : Controller
    {
        private readonly IConfiguration _configuration;
        public AdminregistrationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("registration")]
        public IActionResult registration(Admin admin)
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
            //con.Close();
            /*if (i > 0)
            {
                return Ok("data inserted");
            }
            else
            {
                return Ok("Error");
            }
            */
            return Ok(Result);
        }
    }
}
