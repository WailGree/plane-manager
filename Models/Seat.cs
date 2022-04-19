using System;

namespace PlaneManager.Models
{
    class Seat : DataModel
    {
        public int SeatNumber { get; set; }
        public bool IsBooked { get; set; } = false;


        public Seat(int seatNumber)
        {
            Id = Guid.NewGuid();
            SeatNumber = seatNumber;
        }

        public Seat(Guid guid, int seatNumber, bool isBooked)
        {
            Id = guid;
            SeatNumber = seatNumber;
            IsBooked = isBooked;
        }
    }
}