using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using PlaneManager.Models;

namespace PlaneManager
{
    internal static class Program
    {
        private enum DataType
        {
            Flight,
            Ticket,
            Passenger
        }

        // Save Data globally
        public static List<Passenger> Passengers { get; set; } = new List<Passenger>();
        public static List<Flight> Flights { get; set; } = new List<Flight>();
        public static List<Ticket> Tickets { get; set; } = new List<Ticket>();

        public static readonly string _passengersFile = "passengers.csv";
        public static readonly string _flightsFile = "flights.csv";
        public static readonly string _ticketsFile = "tickets.csv";

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
            LoadDataType(_flightsFile, DataType.Flight);
            LoadDataType(_ticketsFile, DataType.Ticket);
        }

        private static void LoadDataType(string fileName, DataType dataType)
        {
            foreach (var line in File.ReadAllLines(fileName))
            {
                var data = line.Split(';');
                switch (dataType)
                {
                    case DataType.Passenger:
                        Passengers.Add(new Passenger(data));
                        break;
                    case DataType.Flight:
                        Flights.Add(new Flight(data));
                        break;
                    case DataType.Ticket:
                        Tickets.Add(new Ticket(data));
                        break;
                    default:
                        break;
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
                    sw.WriteLine($"{passenger.Name};{passenger.BirthDate};{passenger.PhoneNumber};{passenger.Email}");
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
        public static void SaveFlights()
        {
            if (File.Exists(_flightsFile)) File.Delete(_flightsFile);
            using (var sw = new StreamWriter(_flightsFile))
            {
                foreach (var flight in Flights)
                {
                    sw.WriteLine($"{flight.Id};{flight.Name};{flight.Size}");
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
                    sw.WriteLine($"{ticket.Id};{ticket.IsPurchased};");
                }
            }
        }
        #endregion
    }
}
