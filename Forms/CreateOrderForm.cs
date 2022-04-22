using PlaneManager.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PlaneManager.Forms
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
            selectPassengerComboBox.DataSource = Program.Passengers;
            selectPassengerComboBox.FormattingEnabled = true;
            selectPassengerComboBox.DisplayMember = "Name | PhoneNumber";
            // Only show flights that are still reachable.
            var flights = Program.Flights.Where(flight => flight.DepartureDate > DateTime.Now).ToList();
            flightsComboBox.DataSource = flights;
            flightsComboBox.ValueMember = "Id";
            flightsComboBox.DisplayMember = "Name";

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var flight = Program.Flights.Where(f => f.Id == SelectedFlightGuid).First();
            var hasFreeSeats = flight.Seats.Any(se => se.IsBooked == false);
            var isChosenSeatBooked = flight.Seats.Where(se => se.SeatNumber == Convert.ToInt32(chosenSeatComboBox.Text)).First().IsBooked;
            if (hasFreeSeats)
            {
                if (!isChosenSeatBooked)
                {
                    // Assign passenger to seat
                    var chosenSeatGuid = (Guid)chosenSeatComboBox.SelectedValue;
                    var seat = flight.Seats.Where(s => s.Id == chosenSeatGuid).First();
                    var passenger = Program.Passengers.Where(p => p.Id == ((Passenger)selectPassengerComboBox.SelectedValue).Id).First();
                    seat.Passenger = passenger;
                    seat.IsBooked = true;

                    // Create order
                    var order = new Order(flight, passenger, seat);
                    order.CreateTicket();
                    Program.Orders.Add(order);
                }
                else
                {
                    MessageBox.Show("Seat already taken!", "Seat taken",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("There are no free seats left for this flight!", "Flight is full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FlightsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFlight = (Flight)flightsComboBox.SelectedItem;
            SelectedFlightGuid = Guid.Parse(selectedFlight.Id.ToString());
            if (SelectedFlightGuid != null && selectedFlight != null)
            {
                var result = Program.Flights.Where(f => f.Id == SelectedFlightGuid).First().Seats.Where(s => s.IsBooked == false).ToList();
                if (result != null)
                {
                    chosenSeatComboBox.DataSource = result;
                    chosenSeatComboBox.ValueMember = "Id";
                    chosenSeatComboBox.DisplayMember = "SeatNumber";
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
            string name = ((Passenger)e.ListItem).Name;
            string email = ((Passenger)e.ListItem).Email;
            string phoneNumber = ((Passenger)e.ListItem).PhoneNumber;
            e.Value = $"{name} | {email} | {phoneNumber}";
        }

        private void SearchPassengerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            selectPassengerComboBox.DataSource = null;
            selectPassengerComboBox.DataSource = Program.Passengers.Where(p => p.Name.Contains(searchPassengerNameTextBox.Text)).ToList();
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
