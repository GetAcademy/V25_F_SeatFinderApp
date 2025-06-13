using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeatFinder
{
    internal class Flight
    {
        public string FlightNumber { get; set; }
        public List<Seat> Seats { get; set; }

        public Flight(string flightNumber, int firstClassAmount, int businessAmount, int economyAmount)
        {
            var seatNumber = 1;
            FlightNumber = flightNumber;
            Seats = new List<Seat>();
            for(var i = 0; i < firstClassAmount; i++) Seats.Add(new Seat(seatNumber++, SeatClass.FirstClass));
            for(var i = 0; i < businessAmount; i++) Seats.Add(new Seat(seatNumber++, SeatClass.Business));
            for(var i = 0; i < economyAmount; i++) Seats.Add(new Seat(seatNumber++, SeatClass.Economy));
        }

        public int CountAvailableSeats(SeatClass seatClass)
        {
            return Seats.Count(seat => seat.SeatClass == seatClass && !seat.IsTaken);
        }
    }
}
