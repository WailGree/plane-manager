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
            Plane,
            Flight,
            Ticket
        }

        // Save Data globally
        static List<Plane> Planes { get; set; } = new List<Plane>();
        static List<Flight> Flights { get; set; } = new List<Flight>();
        static List<Ticket> Tickets { get; set; } = new List<Ticket>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LoadData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void LoadData()
        {
            var planesFile = "planes.csv";
            var flightsFile = "flights.csv";
            var ticketsFile = "tickets.csv";

            LoadDataType(planesFile, DataType.Plane);
            LoadDataType(flightsFile, DataType.Flight);
            LoadDataType(ticketsFile, DataType.Ticket);
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
    }
}
