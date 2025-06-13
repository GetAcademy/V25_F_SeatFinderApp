using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatFinder
{
    internal class Seat
    {
        public int SeatNumber { get; set; }
        public SeatClass SeatClass { get; set; }
        public bool IsTaken { get; set; } = false;

        public Seat(int seatNumber, SeatClass seatClass)
        {
            SeatNumber = seatNumber;
            SeatClass = seatClass;
        }
    }
}
