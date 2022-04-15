using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using PlaneManager.Models;
using System.Reflection;

namespace PlaneManager
{
    internal static class Program
    {
        private enum DataType
        {
            Plane,
            Flight,
            Ticket
        }

        // Save Data globally
        public static List<Plane> Planes { get; set; } = new List<Plane>();
        public static List<Flight> Flights { get; set; } = new List<Flight>();
        public static List<Ticket> Tickets { get; set; } = new List<Ticket>();

        private static readonly string _planesFile = "planes.csv";
        private static readonly string _flightsFile = "flights.csv";
        private static readonly string _ticketsFile = "tickets.csv";
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
            LoadDataType(_planesFile, DataType.Plane);
            LoadDataType(_flightsFile, DataType.Flight);
            LoadDataType(_ticketsFile, DataType.Ticket);
        }
        private static void LoadDataType(string fileName, DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Plane:
                    Planes.Clear();
                    break;
                case DataType.Flight:
                    Flights.Clear();
                    break;
                case DataType.Ticket:
                    Tickets.Clear();
                    break;
            }

            if (File.Exists(fileName))
            {
                foreach (var line in File.ReadAllLines(fileName))
                {
                    var data = line.Split(';');
                    switch (dataType)
                    {
                        case DataType.Plane:
                            Planes.Add(new Plane(data));
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
        }
        public static void SaveData()
        {
            SaveDataType(_planesFile, DataType.Plane);
            SaveDataType(_flightsFile, DataType.Flight);
            SaveDataType(_ticketsFile, DataType.Ticket);
        }
        private static void SaveDataType(string fileName, DataType dataType)
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            switch (dataType)
            {
                case DataType.Plane:
                    SavePlanes(fileName);
                    break;
                case DataType.Flight:
                    SaveFlights(fileName);
                    break;
                case DataType.Ticket:
                    SaveTickets(fileName);
                    break;
            }
        }
        private static void SavePlanes(string fileName)
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            using (var sw = new StreamWriter(fileName))
            {
                foreach (var plane in Planes)
                {
                    sw.WriteLine($"{plane.Id};{plane.Name}");
                }
            }
        }
        private static void SaveFlights(string fileName)
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            using (var sw = new StreamWriter(fileName))
            {
                foreach (var flight in Flights)
                {
                    sw.WriteLine($"{flight.Id};{flight.Name};{flight.Size}");
                }
            }
        }
        private static void SaveTickets(string fileName)
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            using (var sw = new StreamWriter(fileName))
            {
                foreach (var ticket in Tickets)
                {
                    sw.WriteLine($"{ticket.Id};{ticket.IsPurchased};");
                }
            }
        }
    }
}
