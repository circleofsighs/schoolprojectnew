using System;
namespace School.BL
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectID { get; set; }

        public void Main(string[] args)
        {
            Subject French = new()
            {
                SubjectName = "French"
            };

            Subject English = new()
            {
                SubjectName = "French"
            };

            Subject Mathematics = new()
            {
                SubjectName = "Mathematics"
            };

            Subject FoodScience = new()
            {
                SubjectName = "Food Science"
            };

            Subject ComputerScience = new()
            {
                SubjectName = "Computer Science"
            };


        }
    }
}
