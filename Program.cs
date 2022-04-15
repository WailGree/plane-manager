using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneManager
{
    internal static class Program
    {

        static List<Plane> Planes { get; set; } = new List<Plane>();
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
        private static void LoadData()
        {
            var fileName = "data.csv";
            if (File.Exists(fileName))
            {
                foreach (var line in File.ReadAllLines(fileName))
                {
                    foreach (var data in line.Split(';'))
                    {
                        //data.
                    }
                }
            }
        }
    }
}
