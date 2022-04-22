using System;

namespace PlaneManager.Models
{
    internal class Ticket : DataModel
    {
        public Guid OrderId { get; set; }
        public int SeatNumber { get; set; }


        public Ticket(Guid orderId, int seatNumber)
        {
            Id = Guid.NewGuid();
            OrderId = orderId;
            SeatNumber = seatNumber;
        }

        public Ticket(string[] data)
        {
            if (data != null && data.Length == 2)
            {
                Id = Guid.Parse(data[0]);
                OrderId = Guid.Parse(data[1]);
                SeatNumber = Convert.ToInt32(data[2]);
            }
        }
    }
}
