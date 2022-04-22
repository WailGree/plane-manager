namespace PlaneManager.Forms
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
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPassengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passangersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePassangersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPassangersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.filterFlightsTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).BeginInit();
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
            this.createFlightToolStripMenuItem,
            this.newOrderToolStripMenuItem});
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
            this.createFlightToolStripMenuItem.Click += new System.EventHandler(this.CreateFlightToolStripMenuItem_Click);
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.NewOrderToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPassengersToolStripMenuItem,
            this.showFlightsToolStripMenuItem,
            this.showOrdersToolStripMenuItem,
            this.showTicketsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showPassengersToolStripMenuItem
            // 
            this.showPassengersToolStripMenuItem.Name = "showPassengersToolStripMenuItem";
            this.showPassengersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.showPassengersToolStripMenuItem.Text = "Show Passengers";
            this.showPassengersToolStripMenuItem.Click += new System.EventHandler(this.ShowPassengersToolStripMenuItem_Click);
            // 
            // showFlightsToolStripMenuItem
            // 
            this.showFlightsToolStripMenuItem.Name = "showFlightsToolStripMenuItem";
            this.showFlightsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.showFlightsToolStripMenuItem.Text = "Show Flights";
            this.showFlightsToolStripMenuItem.Click += new System.EventHandler(this.ShowFlightsToolStripMenuItem_Click);
            // 
            // showOrdersToolStripMenuItem
            // 
            this.showOrdersToolStripMenuItem.Name = "showOrdersToolStripMenuItem";
            this.showOrdersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.showOrdersToolStripMenuItem.Text = "Show Orders";
            this.showOrdersToolStripMenuItem.Click += new System.EventHandler(this.ShowOrdersToolStripMenuItem_Click);
            // 
            // showTicketsToolStripMenuItem
            // 
            this.showTicketsToolStripMenuItem.Name = "showTicketsToolStripMenuItem";
            this.showTicketsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.showTicketsToolStripMenuItem.Text = "Show Tickets";
            this.showTicketsToolStripMenuItem.Click += new System.EventHandler(this.ShowTicketsToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passangersToolStripMenuItem,
            this.flightsToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.ticketsToolStripMenuItem});
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
            this.passangersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFlightsToolStripMenuItem,
            this.loadFlightsToolStripMenuItem});
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.flightsToolStripMenuItem.Text = "Flights";
            // 
            // saveFlightsToolStripMenuItem
            // 
            this.saveFlightsToolStripMenuItem.Name = "saveFlightsToolStripMenuItem";
            this.saveFlightsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveFlightsToolStripMenuItem.Text = "Save Flights";
            this.saveFlightsToolStripMenuItem.Click += new System.EventHandler(this.SaveFlightsToolStripMenuItem_Click);
            // 
            // loadFlightsToolStripMenuItem
            // 
            this.loadFlightsToolStripMenuItem.Name = "loadFlightsToolStripMenuItem";
            this.loadFlightsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.loadFlightsToolStripMenuItem.Text = "Load Flights";
            this.loadFlightsToolStripMenuItem.Click += new System.EventHandler(this.LoadFlightsToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveOrdersToolStripMenuItem,
            this.loadOrdersToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // saveOrdersToolStripMenuItem
            // 
            this.saveOrdersToolStripMenuItem.Name = "saveOrdersToolStripMenuItem";
            this.saveOrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveOrdersToolStripMenuItem.Text = "Save Orders";
            this.saveOrdersToolStripMenuItem.Click += new System.EventHandler(this.SaveOrdersToolStripMenuItem_Click);
            // 
            // loadOrdersToolStripMenuItem
            // 
            this.loadOrdersToolStripMenuItem.Name = "loadOrdersToolStripMenuItem";
            this.loadOrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadOrdersToolStripMenuItem.Text = "Load Orders";
            this.loadOrdersToolStripMenuItem.Click += new System.EventHandler(this.LoadOrdersToolStripMenuItem_Click);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTicketsToolStripMenuItem,
            this.loadTicketsToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // saveTicketsToolStripMenuItem
            // 
            this.saveTicketsToolStripMenuItem.Name = "saveTicketsToolStripMenuItem";
            this.saveTicketsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveTicketsToolStripMenuItem.Text = "Save Tickets";
            this.saveTicketsToolStripMenuItem.Click += new System.EventHandler(this.SaveTicketsToolStripMenuItem_Click);
            // 
            // loadTicketsToolStripMenuItem
            // 
            this.loadTicketsToolStripMenuItem.Name = "loadTicketsToolStripMenuItem";
            this.loadTicketsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.loadTicketsToolStripMenuItem.Text = "Load Tickets";
            // 
            // detailsDataGridView
            // 
            this.detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsDataGridView.Location = new System.Drawing.Point(12, 58);
            this.detailsDataGridView.Name = "detailsDataGridView";
            this.detailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailsDataGridView.Size = new System.Drawing.Size(776, 380);
            this.detailsDataGridView.TabIndex = 2;
            // 
            // filterFlightsTextBox
            // 
            this.filterFlightsTextBox.Location = new System.Drawing.Point(688, 32);
            this.filterFlightsTextBox.Name = "filterFlightsTextBox";
            this.filterFlightsTextBox.Size = new System.Drawing.Size(100, 20);
            this.filterFlightsTextBox.TabIndex = 3;
            this.filterFlightsTextBox.TextChanged += new System.EventHandler(this.FilterFlightsTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filterFlightsTextBox);
            this.Controls.Add(this.detailsDataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView detailsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem showFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFlightsToolStripMenuItem;
        private System.Windows.Forms.TextBox filterFlightsTextBox;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTicketsToolStripMenuItem;
    }
}

