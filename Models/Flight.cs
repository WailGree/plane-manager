using System;
using System.ComponentModel;

namespace PlaneManager.Models
{
    internal class Flight : DataModel
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public BindingList<Passenger> Passengers { get; set; } = new BindingList<Passenger>();
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }


        public Flight(string[] data)
        {
            if (data != null && data.Length == 7)
            {
                if (Guid.TryParse(data[0], out Guid id))
                {
                    Id = id;
                }
                Name = data[1];
                if (int.TryParse(data[2], out int size))
                {
                    Size = size;
                }
                else
                {
                    Size = 0;
                }
            }
            if (DateTime.TryParse(data[3], out DateTime departureDate))
            {
                DepartureDate = departureDate;
                // If no valid DepartureDate, don't even bother with ArrivalDate parse
                if (DateTime.TryParse(data[4], out DateTime arrivalDate))
                {
                    ArrivalDate = arrivalDate;
                }
            }
            Departure = data[5];
            Destination = data[6];
            //DepartureDate = data[2];
        }

        public Flight(Guid guid, string name, int size, DateTime departureDate, DateTime arrivalDate, string departure, string destination)
        {
            Id = guid;
            Name = name;
            Size = size;
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            Departure = departure;
            Destination = destination;
        }
    }
}
