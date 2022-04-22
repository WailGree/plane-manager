using System;

namespace PlaneManager.Models
{
    class Seat : DataModel
    {
        public int SeatNumber { get; set; }
        public bool IsBooked { get; set; } = false;
        public Passenger Passenger { get; set; }

        public Seat(int seatNumber)
        {
            Id = Guid.NewGuid();
            SeatNumber = seatNumber;
        }

        public Seat(string[] data)
        {
            if (data != null && data.Length == 3 && Guid.TryParse(data[0], out Guid guid) && int.TryParse(data[1], out int seatNumber) && bool.TryParse(data[2], out bool isBooked))
            {
                Id = guid;
                SeatNumber = seatNumber;
                IsBooked = isBooked;
            }
        }

        public Seat(Guid guid, int seatNumber, bool isBooked)
        {
            Id = guid;
            SeatNumber = seatNumber;
            IsBooked = isBooked;
        }
    }
}