using System;
namespace School.BL
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public int BuildingID { get; set; }

        public void Main(string[] args)
        {
            Room A = new Room();
            A.RoomNumber = 107;

            Room B = new Room();
            B.RoomNumber = 22;

            Room C = new Room();
            C.RoomNumber = 493;

            Room D = new Room();
            D.RoomNumber = 222;

            Room E = new Room();
            E.RoomNumber = 105;


        }

    }
}
