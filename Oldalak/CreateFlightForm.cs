using System;
using System.Windows.Forms;

namespace PlaneManager.Oldalak
{
    public partial class CreateFlightForm : Form
    {
        private static string EgyediAdatFormatum { get; } = "   yyyy,MMMM,dd,dddd hh:mm:ss";
        public CreateFlightForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text) && !string.IsNullOrEmpty(departureTextBox.Text) && !string.IsNullOrEmpty(destinationTextBox.Text))
            {
                Program.JaratLetrehozasa(nameTextBox.Text, Decimal.ToInt32(sizeNumericUpDown.Value), departureDateTimePicker.Value, arrivalDateTimePicker.Value, departureTextBox.Text, destinationTextBox.Text);
                Close();
            }
            else
            {
                MessageBox.Show("Kérem töltse ki az oldalt!", "Üres mező",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CreateFlightForm_Load(object sender, EventArgs e)
        {
            departureDateTimePicker.Format = DateTimePickerFormat.Custom;
            departureDateTimePicker.CustomFormat = EgyediAdatFormatum;
            arrivalDateTimePicker.Format = DateTimePickerFormat.Custom;
            arrivalDateTimePicker.CustomFormat = EgyediAdatFormatum;
        }
    }
}
