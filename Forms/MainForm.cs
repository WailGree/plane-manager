using System;
using System.IO;
using System.Windows.Forms;

namespace PlaneManager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void SavePassangersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.SavePassengers();
        }

        private void LoadPassangersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Program._passengersFile))
            {
                Program.LoadPassangers();
            }
            else
            {
                MessageBox.Show($"Save file \"{Program._passengersFile}\" not found.", "File not found",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }

        private void CreatePassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Program.CreatePassenger("Joe", "2022-01-01", "06202828282", "elvador@gmail.com");
            using (var cPF = new CreatePassengerForm())
            {
                if (cPF.ShowDialog() == DialogResult.OK)
                {
                    cPF.Close();
                }
            }
        }

        private void ShowPassengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailsDataGridView.DataSource = Program.Passengers;
        }
        private void ShowFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailsDataGridView.DataSource = Program.Flights;
        }

        private void CreateFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var cFF = new CreateFlightForm())
            {
                if (cFF.ShowDialog() == DialogResult.OK)
                {
                    cFF.Close();
                }
            }
        }

        private void SaveFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.SaveFlights();
        }

        private void LoadFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Program._flightsFile))
            {
                Program.LoadFlights();
            }
            else
            {
                MessageBox.Show($"Save file \"{Program._flightsFile}\" not found.", "File not found",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }
    }
}
