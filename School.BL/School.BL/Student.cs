using System;

namespace School.BL
{
    public class Student
    {
        public string StudentID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int GraduationYear { get; set; }
        public int ClassesID { get; set; }
        public bool Deleted { get; set; }

         // Add methods

        public void Main(string[] args)
        {
            Student Gary = new Student();
            Gary.FirstName = "Gary";
            Gary.LastName = "Stevens";
            Gary.BirthYear = 2005;
            Gary.GraduationYear = 2024;

            Student Roberta = new Student();
            Gary.FirstName = "Roberta";
            Gary.LastName = "Stevens";
            Gary.BirthYear = 2007;
            Gary.GraduationYear = 2026;

            Student HaeKwon = new Student();
            Gary.FirstName = "Hae Kwon;
            Gary.LastName = "Lin";
            Gary.BirthYear = 2004;
            Gary.GraduationYear = 2022;

            Student Vanya = new Student();
            Gary.FirstName = "Vanya";
            Gary.LastName = "Rees";
            Gary.BirthYear = 2006;
            Gary.GraduationYear = 2024;

            Student Matthew = new Student();
            Gary.FirstName = "Matthew";
            Gary.LastName = "Vinh";
            Gary.BirthYear = 2000;
            Gary.GraduationYear = 2022;

        }
    }


}
