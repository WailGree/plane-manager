using System;

namespace PlaneManager.Models
{
    internal class Flight : DataModel
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public Seat[] Seats { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }


        public Flight(string[] data)
        {
            if (data != null && data.Length >= 7 && Guid.TryParse(data[0], out Guid id) && int.TryParse(data[2], out int size) && DateTime.TryParse(data[3 + size * 3], out DateTime departureDate) && DateTime.TryParse(data[3 + size * 3 + 1], out DateTime arrivalDate))
            {
                Id = id;
                Name = data[1];
                Size = size;

                if (Size > 0)
                {
                    Seats = new Seat[Size];
                    int seatIndex = 0;
                    for (int x = 3; x <= (1 + Size * 3); x += 3)
                    {
                        Seats[seatIndex] = new Seat(new string[] { data[x], data[x + 1], data[x + 2] });
                        seatIndex++;
                    }
                }
                else
                {
                    Seats = new Seat[0];
                }

                DepartureDate = departureDate;
                ArrivalDate = arrivalDate;
                Departure = data[3 + Size * 3 + 2];
                Destination = data[3 + Size * 3 + 3];
            }
        }

        public Flight(string name, int size, DateTime departureDate, DateTime arrivalDate, string departure, string destination)
        {
            Id = Guid.NewGuid();
            Name = name;
            Size = size;
            Seats = new Seat[Size];
            for (int i = 0; i < Size; i++)
            {
                Seats[i] = new Seat(i + 1);
            }
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            Departure = departure;
            Destination = destination;
        }
    }
}
