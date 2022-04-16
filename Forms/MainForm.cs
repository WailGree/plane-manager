using PlaneManager.Views;
using System;
using System.IO;
using System.Windows.Forms;

namespace PlaneManager
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
                ReloadDisplay();
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
            using(var cPF = new CreatePassengerForm())
            {
                //cPF.ShowDialog();
                if(cPF.ShowDialog() == DialogResult.OK)
                {
                    cPF.Close();
                }
            }
            ReloadDisplay();
        }

        private void ReloadDisplay()
        {
            passengerViewList.Items.Clear();
            foreach (var passenger in Program.Passengers)
            {
                var newPassenger = new ListViewItem(passenger.Name);
                newPassenger.SubItems.Add(passenger.BirthDate);
                newPassenger.SubItems.Add(passenger.PhoneNumber);
                newPassenger.SubItems.Add(passenger.Email);
                passengerViewList.Items.Add(newPassenger);
            }
        }

        private void ShowPassengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passengerViewList.Show();
        }
    }
}
