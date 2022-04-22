using System;

namespace PlaneManager.Models
{
    internal class Order : DataModel
    {
        public Flight Flight { get; set; }
        public Passenger Passenger { get; set; }
        public Seat Seat { get; set; }
        public Ticket Ticket { get; set; }

        public Order(Flight flight, Passenger passenger, Seat seat)
        {
            Id = Guid.NewGuid();
            Flight = flight;
            Passenger = passenger;
            Seat = seat;
        }

        public Order(string[] data)
        {

        }

        public void CreateTicket()
        {
            var ticket = new Ticket(Id, Seat.SeatNumber);
            Ticket = ticket;
            Program.Tickets.Add(ticket);
        }


    }
}
