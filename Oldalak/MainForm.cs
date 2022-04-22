using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PlaneManager.Oldalak
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            filterFlightsTextBox.Hide();
        }

        private void SavePassangersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.UtasokMentese();
        }

        private void LoadPassangersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Program._utasokFajl))
            {
                Program.UtasokBetoltese();
            }
            else
            {
                MessageBox.Show($"Save file \"{Program._utasokFajl}\" not found.", "File not found",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }

        private void CreatePassengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            detailsDataGridView.DataSource = Program.Utasok;
            filterFlightsTextBox.Hide();
        }

        private void ShowFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailsDataGridView.DataSource = Program.Jaratok;
            filterFlightsTextBox.Show();
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
            Program.JaratokMentese();
        }

        private void LoadFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Program._jaratokFajl))
            {
                Program.JaratokBetoltese();
            }
            else
            {
                MessageBox.Show($"Save file \"{Program._jaratokFajl}\" not found.", "File not found",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
        }

        private void FilterFlightsTextBox_TextChanged(object sender, EventArgs e)
        {
            detailsDataGridView.DataSource = Program.Jaratok.Where(f => f.Nev.Contains(filterFlightsTextBox.Text)).ToList();
        }

        private void NewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var cOF = new CreateOrderForm())
            {
                if (cOF.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void ShowOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailsDataGridView.DataSource = Program.Rendelesek;
            filterFlightsTextBox.Hide();
        }

        private void SaveOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.RendelesekMentese();
        }

        private void LoadOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ShowTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailsDataGridView.DataSource = Program.Jegyek;
            filterFlightsTextBox.Hide();
        }
    }
}
