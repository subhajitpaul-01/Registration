using System.Numerics;

namespace LMS_Project2.Models
{
    public class Registration
    {
        public int Student_Id { get; set; }
        public string Student_Fname { get; set; }
        public string Student_Lname { get; set; }
        public string Student_Email { get; set; }
        public string Student_Password { get; set; }


        public string Student_Address { get; set; }
       // public DateTime Enroll_Date { get; set; }
        public long Student_ContactNo { get; set; }
        public string Course_Name { get; set; }
        public string Batch_Name { get; set; }
        public  byte Photo { get; set; }
        public byte Doccuments { get; set; }
        public int Batch_Id { get; set; }
        public int Course_Id { get; set; }
       // public DateTime Date_of_App { get; set; }
       // public DateTime Date_of_Reg { get; set; }
        public string Email_Status{ get; set; }
        public string Status { get; set; }
        public string Edu_Title_10 { get; set; }
        public string Edu_10_snm { get; set; }
        public string Edu_10_bnm { get; set; }
        public long Edu_10_yr { get; set; }
        public float Edu_10_mrkp { get; set; }
        public string Edu_12_Title { get; set; }
        public string Edu_12_snm { get; set; }
        public string Edu_12_bnm { get; set; }
        public long Edu_12_yr { get; set; }
        public float Edu_12_mrkp { get; set; }
        public string Edu_Title_grd { get; set; }
        public string Edu_grd_cnm { get; set; }
        public string Edu_grd_unm { get; set; }
        public long Edu_grd_yr { get; set; }
        public float Edu_grd_mrkp { get; set; }
        public string Post_grd_Title { get; set; }
        public string Post_grd_cnm { get; set; }
        public string Post_grd_unm { get; set; }
        public long Post_grd_yr { get; set; }
        public float Post_grd_mrkp { get; set; }
        public string Certi_Title1 { get; set; }
        public byte Certi_File1 { get; set; }
        public string Certi_Title2 { get; set; }
        public byte Certi_File2 { get; set; }
        public string Certi_Title3 { get; set; }
        public byte Certi_File3 { get; set; }
        public string Internship1 { get; set; }
        public string Internship_Cname1 { get; set; }
        public string Intern_dept1 { get; set; }
        public string Intern_posi1 { get; set; }
        public string Intern_Skill1 { get; set; }
        public string Program_lang1 { get; set; }
        public string Program_lang2 { get; set; }
        public string Program_lang3 { get; set; }
        public string Program_lang4 { get; set; }
        public string Framework1 { get; set; }
        public string Framework2 { get; set; }
        public string Framework3 { get; set; }
        public string Web_Tech1 { get; set; }
        public string Web_Tech2 { get; set; }
        public string Web_Tech3 { get; set; }
        public string Os1 { get; set; }
        public string Os2 { get; set; }
        public string Database1 { get; set; }
        public string Database2 { get; set; }
        public string Extra_Cur1 { get; set; }
        public string Extra_Cur2 { get; set; }
        public string Extra_Cur3 { get; set; }
        public string Hobby1 { get; set; }
        public string Hobby2 { get; set; }
        public string Hobby3 { get; set; }
     }
    public class Admin 
    { 

        public string? Admin_Name { get; set; }
        public string? Admin_Email { get; set; }
        public string? Admin_Password { get; set;}

    }
}
