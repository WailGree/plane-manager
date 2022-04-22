using System;
using System.IO;
using System.Windows.Forms;
using PlaneManager.Models;
using PlaneManager.Forms;
using System.ComponentModel;
using System.Text;

namespace PlaneManager
{
    internal static class Program
    {
        private enum DataType
        {
            Flight,
            Passenger,
            Order,
            Ticket
        }

        // Save Data globally
        // Using BindingList instead of List will make it possible, to update DataGridView on change of data. With simple List it will NOT fire event/update view.
        public static BindingList<Passenger> Passengers { get; set; } = new BindingList<Passenger>();
        public static BindingList<Flight> Flights { get; set; } = new BindingList<Flight>();
        public static BindingList<Ticket> Tickets { get; set; } = new BindingList<Ticket>();
        public static BindingList<Order> Orders { get; set; } = new BindingList<Order>();

        public static readonly string _passengersFile = "passengers.csv";
        public static readonly string _flightsFile = "flights.csv";
        public static readonly string _ticketsFile = "tickets.csv";
        public static readonly string _ordersFile = "orders.csv";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public static void LoadData()
        {
            LoadDataType(_passengersFile, DataType.Passenger);
            LoadDataType(_flightsFile, DataType.Flight);
            LoadDataType(_ticketsFile, DataType.Ticket);
            LoadDataType(_ordersFile, DataType.Order);
        }

        private static void LoadDataType(string fileName, DataType dataType)
        {
            foreach (var line in File.ReadAllLines(fileName))
            {
                var data = line.Split(';');
                if (dataType == DataType.Passenger)
                {
                    Passengers.Add(new Passenger(data));
                }
                else if (dataType == DataType.Flight)
                {
                    Flights.Add(new Flight(data));
                }
                else if(dataType == DataType.Order)
                {
                    Orders.Add(new Order(data));
                }
                else if (dataType == DataType.Ticket)
                {
                    Tickets.Add(new Ticket(data));
                }
            }
        }

        public static void SaveAllData()
        {
            SavePassengers();
            SaveFlights();
            SaveTickets();
        }

        #region Passangers related functions
        public static void CreatePassenger(string name, string birthdate, string phonenumber, string email)
        {
            Passengers.Add(new Passenger(name, birthdate, phonenumber, email));
        }

        public static void SavePassengers()
        {

            if (File.Exists(_passengersFile)) File.Delete(_passengersFile);
            using (var sw = new StreamWriter(_passengersFile))
            {
                foreach (var passenger in Passengers)
                {
                    sw.WriteLine($"{passenger.Id};{passenger.Name};{passenger.BirthDate};{passenger.PhoneNumber};{passenger.Email}");
                }
            }
        }

        public static void LoadPassangers()
        {
            if (File.Exists(_passengersFile))
            {
                Passengers.Clear();
                LoadDataType(_passengersFile, DataType.Passenger);
            }
        }
        #endregion

        #region Flights related functions
        public static void CreateFlight(string name, int size, DateTime departureDate, DateTime arrivalDate, string departure, string destination)
        {
            Flights.Add(new Flight(name, size, departureDate, arrivalDate, departure, destination));
        }
        public static void SaveFlights()
        {
            if (File.Exists(_flightsFile)) File.Delete(_flightsFile);
            using (var sw = new StreamWriter(_flightsFile))
            {
                foreach (var flight in Flights)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"{flight.Id};{flight.Name};{flight.Size};");
                    if (flight.Size > 0)
                    {
                        foreach (var seat in flight.Seats)
                        {
                            sb.Append($"{seat.Id};{seat.SeatNumber};{seat.IsBooked};");
                        }
                    }
                    sb.Append($"{flight.DepartureDate};{flight.ArrivalDate};{flight.Departure};{flight.Destination}");
                    sw.WriteLine(sb);
                }
            }
        }

        public static void LoadFlights()
        {
            if (File.Exists(_flightsFile))
            {
                Flights.Clear();
                LoadDataType(_flightsFile, DataType.Flight);
            }
        }
        #endregion
        #region Orders related functions
        public static void SaveOrders()
        {
            if (File.Exists(_ordersFile)) File.Delete(_ordersFile);
            using (var sw = new StreamWriter(_ordersFile))
            {
                foreach (var order in Orders)
                {
                    sw.WriteLine($"{order.Id};{order.Flight};{order.Passenger};{order.Seat};{order.Ticket}");
                }
            }
        }
        #endregion
        #region Tickets related functions
        public static void SaveTickets()
        {
            if (File.Exists(_ticketsFile)) File.Delete(_ticketsFile);
            using (var sw = new StreamWriter(_ticketsFile))
            {
                foreach (var ticket in Tickets)
                {
                    sw.WriteLine($"{ticket.Id};{ticket.OrderId};{ticket.SeatNumber}");
                }
            }
        }

        public static void LoadTickets()
        {
            if (File.Exists(_ticketsFile))
            {
                Tickets.Clear();
                LoadDataType(_ticketsFile, DataType.Ticket);
            }
        }
        #endregion
    }
}
