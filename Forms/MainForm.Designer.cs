namespace PlaneManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPassengerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPassengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passangersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePassangersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPassangersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengersDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPassengerToolStripMenuItem,
            this.createFlightToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // createPassengerToolStripMenuItem
            // 
            this.createPassengerToolStripMenuItem.Name = "createPassengerToolStripMenuItem";
            this.createPassengerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.createPassengerToolStripMenuItem.Text = "New Passenger";
            this.createPassengerToolStripMenuItem.Click += new System.EventHandler(this.CreatePassengerToolStripMenuItem_Click);
            // 
            // createFlightToolStripMenuItem
            // 
            this.createFlightToolStripMenuItem.Name = "createFlightToolStripMenuItem";
            this.createFlightToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.createFlightToolStripMenuItem.Text = "New Flight";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPassengersToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showPassengersToolStripMenuItem
            // 
            this.showPassengersToolStripMenuItem.Name = "showPassengersToolStripMenuItem";
            this.showPassengersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPassengersToolStripMenuItem.Text = "Show Passengers";
            this.showPassengersToolStripMenuItem.Click += new System.EventHandler(this.ShowPassengersToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passangersToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // passangersToolStripMenuItem
            // 
            this.passangersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePassangersToolStripMenuItem,
            this.loadPassangersToolStripMenuItem});
            this.passangersToolStripMenuItem.Name = "passangersToolStripMenuItem";
            this.passangersToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.passangersToolStripMenuItem.Text = "Passangers";
            // 
            // savePassangersToolStripMenuItem
            // 
            this.savePassangersToolStripMenuItem.Name = "savePassangersToolStripMenuItem";
            this.savePassangersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.savePassangersToolStripMenuItem.Text = "Save Passangers";
            this.savePassangersToolStripMenuItem.Click += new System.EventHandler(this.SavePassangersToolStripMenuItem_Click);
            // 
            // loadPassangersToolStripMenuItem
            // 
            this.loadPassangersToolStripMenuItem.Name = "loadPassangersToolStripMenuItem";
            this.loadPassangersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.loadPassangersToolStripMenuItem.Text = "Load Passangers";
            this.loadPassangersToolStripMenuItem.Click += new System.EventHandler(this.LoadPassangersToolStripMenuItem_Click);
            // 
            // passengersDataGridView
            // 
            this.passengersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengersDataGridView.Location = new System.Drawing.Point(12, 27);
            this.passengersDataGridView.Name = "passengersDataGridView";
            this.passengersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passengersDataGridView.Size = new System.Drawing.Size(776, 411);
            this.passengersDataGridView.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passengersDataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passengersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passangersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePassangersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPassangersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPassengerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFlightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPassengersToolStripMenuItem;
        private System.Windows.Forms.DataGridView passengersDataGridView;
    }
}

