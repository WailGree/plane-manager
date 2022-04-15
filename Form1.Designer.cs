namespace PlaneManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.DataLoadDataMenuItem = new System.Windows.Forms.MenuItem();
            this.DataSaveDataMenuItem = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.DataLoadDataMenuItem,
            this.DataSaveDataMenuItem});
            this.menuItem2.Text = "Data";
            // 
            // DataLoadDataMenuItem
            // 
            this.DataLoadDataMenuItem.Index = 0;
            this.DataLoadDataMenuItem.Text = "Load data";
            this.DataLoadDataMenuItem.Click += new System.EventHandler(this.DataLoadDataMenuItem_Click);
            // 
            // DataSaveDataMenuItem
            // 
            this.DataSaveDataMenuItem.Index = 1;
            this.DataSaveDataMenuItem.Text = "Save data";
            this.DataSaveDataMenuItem.Click += new System.EventHandler(this.DataSaveDataMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Plane Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem DataLoadDataMenuItem;
        private System.Windows.Forms.MenuItem DataSaveDataMenuItem;
    }
}

