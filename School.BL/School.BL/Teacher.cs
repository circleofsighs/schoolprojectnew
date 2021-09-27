using System;
namespace School.BL
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int CareerStartYear { get; set; }
        public int ClassesID { get; set; }
        public bool Deleted { get; set; }

        
        public void Main(string[] args)
        {
            Teacher Steve = new Teacher
            {
                FirstName = "Steve",
                LastName = "Banks",
                BirthYear = 1990,
                CareerStartYear = 2018
            };

            Teacher Sally = new Teacher();
            Steve.FirstName = "Sally";
            Steve.LastName = "Trigg";
            Steve.BirthYear = 1965;
            Steve.CareerStartYear = 1987;

            Teacher Mary = new Teacher();
            Steve.FirstName = "Mary";
            Steve.LastName = "Masters";
            Steve.BirthYear = 1986;
            Steve.CareerStartYear = 2010;

            Teacher Barry = new Teacher();
            Steve.FirstName = "Barry";
            Steve.LastName = "Benson";
            Steve.BirthYear = 1930;
            Steve.CareerStartYear = 1950;

            Teacher Melissa = new Teacher();
            Steve.FirstName = "Melissa";
            Steve.LastName = "Ryan";
            Steve.BirthYear = 1999;
            Steve.CareerStartYear = 2021;
        }

        

        
    }
}
