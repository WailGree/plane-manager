using System;
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
            LoadPlanesForView();
        }

        private void DataLoadDataMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoadData();
            LoadPlanesForView();
        }

        private void DataSaveDataMenuItem_Click(object sender, EventArgs e)
        {
            Program.SaveData();
        }

        private void LoadPlanesForView()
        {
            PlaneViewList.DataBindings.Clear();
            foreach (var plane in Program.Planes)
            {
                var newPlane = new ListViewItem(plane.Id.ToString());
                newPlane.SubItems.Add(plane.Name);
                PlaneViewList.Items.Add(newPlane);
            }
        }
    }
}
