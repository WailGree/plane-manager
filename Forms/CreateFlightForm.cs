using System;
using System.Windows.Forms;

namespace PlaneManager.Forms
{
    public partial class CreateFlightForm : Form
    {
        private static string CustomDateTimePickerFormat { get; } = "   yyyy,MMMM,dd,dddd hh:mm:ss";
        public CreateFlightForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrEmpty(departureTextBox.Text) && !string.IsNullOrEmpty(destinationTextBox.Text))
            {
                Program.CreateFlight(nameTextBox.Text, Decimal.ToInt32(sizeNumericUpDown.Value), departureDateTimePicker.Value, arrivalDateTimePicker.Value, departureTextBox.Text, destinationTextBox.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Please fill out the missing fields!", "Required fields empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CreateFlightForm_Load(object sender, EventArgs e)
        {
            departureDateTimePicker.Format = DateTimePickerFormat.Custom;
            departureDateTimePicker.CustomFormat = CustomDateTimePickerFormat;
            arrivalDateTimePicker.Format = DateTimePickerFormat.Custom;
            arrivalDateTimePicker.CustomFormat = CustomDateTimePickerFormat;
        }
    }
}
