using System;
namespace School.BL
{
    public class Building
    {
        public string BuildingName { get; set; }
        public int BuildingNumber { get; set; }

        public void Main(string[] args)
        {
            Building OneA = new Building();
            OneA.BuildingName = "Kitchens";

            Building OneB = new Building();
            OneA.BuildingName = "Classrooms";
        }
    }
}
