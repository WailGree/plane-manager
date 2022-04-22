using System;
using System.Windows.Forms;

namespace PlaneManager.Oldalak
{
    public partial class CreatePassengerForm : Form
    {
        public CreatePassengerForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) && string.IsNullOrEmpty(birthDateTextBox.Text) && string.IsNullOrEmpty(PhoneNumberTextBox.Text) && string.IsNullOrEmpty(EmailTextBox.Text))
            {
                MessageBox.Show("Kérem töltse ki az oldalt!", "Üres mező",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
            else
            {
                Program.UtasLetrehozasa(nameTextBox.Text, birthDateTextBox.Text, PhoneNumberTextBox.Text, EmailTextBox.Text);
                Close();
            }
        }
    }
}
