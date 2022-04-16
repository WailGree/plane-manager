using System;
using System.Windows.Forms;

namespace PlaneManager.Views
{
    public partial class CreatePassengerForm : Form
    {
        public CreatePassengerForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nameTextBox.Text) && string.IsNullOrEmpty(birthDateTextBox.Text) && string.IsNullOrEmpty(PhoneNumberTextBox.Text) && string.IsNullOrEmpty(EmailTextBox.Text))
            {
                MessageBox.Show("Please fill out the missing fields!", "Required fields empty",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
            else
            {
                Program.CreatePassenger(nameTextBox.Text, birthDateTextBox.Text, PhoneNumberTextBox.Text, EmailTextBox.Text);
                Close();
            }
        }
    }
}
