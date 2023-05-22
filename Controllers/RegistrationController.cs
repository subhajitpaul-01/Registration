using LMS_Project2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
namespace LMS_Project2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        /*private readonly IConfiguration _configuration;
        public RegistrationController(IConfiguration configuration)
        {
            _configuration= configuration;
        }
        //Admin Registration
        [HttpPost]
        [Route("registration")]
        public IActionResult registration(Registration registration)

        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("LMS").ToString());

            //SqlCommand cmd = new SqlCommand("INSERT INTO Admin(Admin_Name,Admin_Email,Student_Password) VALUES('"+registration.Student_Fname+ "','"+registration.Student_Lname +"','" + registration.Student_Email +"','" + registration.Student_Password + "' )", con);
            SqlCommand cmd = new SqlCommand("LMS_Intern", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            {
                return Ok("data inserted");
            }
            else
            {
                return Ok("Error");
            }

        }
        //Admin Login
        [HttpPost]
        [Route("login")]
        public string login(Registration registration)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("LMS").ToString());
           //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student WHERE Email = '" + registration.Student_Email + "' AND Password = '" + registration.Student_Password + "'", con);
            SqlDataAdapter da = new SqlDataAdapter("LMS_Adminlogin" ,con);
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
        //Student Login
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
        }*/
    }

}
 