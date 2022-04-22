using PlaneManager.Modellek;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PlaneManager.Oldalak
{
    public partial class CreateOrderForm : Form
    {
        public Guid SelectedFlightGuid { get; private set; }
        public Guid SelectedPassengerGuid { get; private set; }

        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            createPassengerButton.Hide();
            selectPassengerComboBox.DataSource = Program.Utasok;
            selectPassengerComboBox.FormattingEnabled = true;
            selectPassengerComboBox.DisplayMember = "Nev | Telefonszam";

            var flights = Program.Jaratok.Where(j => j.IndulasIdeje > DateTime.Now).ToList();
            flightsComboBox.DataSource = flights;
            flightsComboBox.ValueMember = "Id";
            flightsComboBox.DisplayMember = "Nev";

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var flight = Program.Jaratok.Where(j => j.Id == SelectedFlightGuid).First();
            var hasFreeSeats = flight.Ulesek.Any(u => u.Lefoglalt == false);
            var isChosenSeatBooked = flight.Ulesek.Where(u => u.SzekSzama == Convert.ToInt32(chosenSeatComboBox.Text)).First().Lefoglalt;
            if (hasFreeSeats)
            {
                if (!isChosenSeatBooked)
                {

                    var ulesId = (Guid)chosenSeatComboBox.SelectedValue;
                    var ules = flight.Ulesek.Where(u => u.Id == ulesId).First();
                    var utas = Program.Utasok.Where(u => u.Id == ((Utas)selectPassengerComboBox.SelectedValue).Id).First();
                    ules.Utas = utas;
                    ules.Lefoglalt = true;

                    var rendeles = new Rendeles(flight, utas, ules);
                    rendeles.JegyLetrehozasa();
                    Program.Rendelesek.Add(rendeles);
                }
                else
                {
                    MessageBox.Show("Az ülés foglalt!", "Ülés foglalt",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nincsenek szabad ülések a vonaton!", "A jarat megtelt",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FlightsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFlight = (Jarat)flightsComboBox.SelectedItem;
            SelectedFlightGuid = Guid.Parse(selectedFlight.Id.ToString());
            if (SelectedFlightGuid != null && selectedFlight != null)
            {
                var result = Program.Jaratok.Where(j => j.Id == SelectedFlightGuid).First().Ulesek.Where(u => u.Lefoglalt == false).ToList();
                if (result != null)
                {
                    chosenSeatComboBox.DataSource = result;
                    chosenSeatComboBox.ValueMember = "Id";
                    chosenSeatComboBox.DisplayMember = "UlesSzama";
                }
            }
        }

        private void IsNewPassengerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isNewPassengerCheckBox.Checked)
            {
                createPassengerButton.Show();

            }
            else
            {
                createPassengerButton.Hide();
            }
        }

        private void SelectPassengerComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string nev = ((Utas)e.ListItem).Nev;
            string email = ((Utas)e.ListItem).Email;
            string telefonszam = ((Utas)e.ListItem).Telefonszam;
            e.Value = $"{nev} | {email} | {telefonszam}";
        }

        private void SearchPassengerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            selectPassengerComboBox.DataSource = null;
            selectPassengerComboBox.DataSource = Program.Utasok.Where(u => u.Nev.Contains(searchPassengerNameTextBox.Text)).ToList();
        }

        private void CreatePassengerButton_Click(object sender, EventArgs e)
        {
            using (var cPF = new CreatePassengerForm())
            {
                if (cPF.ShowDialog() == DialogResult.OK)
                {
                    cPF.Close();
                }
            }
        }
    }
}
