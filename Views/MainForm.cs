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

        private void LoadPlanesForView()
        {
            planeViewList.DataBindings.Clear();
            foreach (var plane in Program.Planes)
            {
                var newPlane = new ListViewItem(plane.Id.ToString());
                newPlane.SubItems.Add(plane.Name);
                planeViewList.Items.Add(newPlane);
            }
        }
    }
}
