namespace PlaneManager.Forms
{
    partial class CreateOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrderForm));
            this.flightsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPassengerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chosenSeatComboBox = new System.Windows.Forms.ComboBox();
            this.selectPassengerComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isNewPassengerCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createPassengerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flightsComboBox
            // 
            resources.ApplyResources(this.flightsComboBox, "flightsComboBox");
            this.flightsComboBox.FormattingEnabled = true;
            this.flightsComboBox.Name = "flightsComboBox";
            this.flightsComboBox.SelectedIndexChanged += new System.EventHandler(this.FlightsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // searchPassengerNameTextBox
            // 
            resources.ApplyResources(this.searchPassengerNameTextBox, "searchPassengerNameTextBox");
            this.searchPassengerNameTextBox.Name = "searchPassengerNameTextBox";
            this.searchPassengerNameTextBox.TextChanged += new System.EventHandler(this.SearchPassengerNameTextBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // createButton
            // 
            resources.ApplyResources(this.createButton, "createButton");
            this.createButton.Name = "createButton";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // chosenSeatComboBox
            // 
            resources.ApplyResources(this.chosenSeatComboBox, "chosenSeatComboBox");
            this.chosenSeatComboBox.FormattingEnabled = true;
            this.chosenSeatComboBox.Name = "chosenSeatComboBox";
            // 
            // selectPassengerComboBox
            // 
            resources.ApplyResources(this.selectPassengerComboBox, "selectPassengerComboBox");
            this.selectPassengerComboBox.FormattingEnabled = true;
            this.selectPassengerComboBox.Name = "selectPassengerComboBox";
            this.selectPassengerComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.SelectPassengerComboBox_Format);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // isNewPassengerCheckBox
            // 
            resources.ApplyResources(this.isNewPassengerCheckBox, "isNewPassengerCheckBox");
            this.isNewPassengerCheckBox.Name = "isNewPassengerCheckBox";
            this.isNewPassengerCheckBox.UseVisualStyleBackColor = true;
            this.isNewPassengerCheckBox.CheckedChanged += new System.EventHandler(this.IsNewPassengerCheckBox_CheckedChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // createPassengerButton
            // 
            resources.ApplyResources(this.createPassengerButton, "createPassengerButton");
            this.createPassengerButton.Name = "createPassengerButton";
            this.createPassengerButton.UseVisualStyleBackColor = true;
            this.createPassengerButton.Click += new System.EventHandler(this.CreatePassengerButton_Click);
            // 
            // CreateOrderForm
            // 
            this.AcceptButton = this.createButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.createPassengerButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isNewPassengerCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectPassengerComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chosenSeatComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchPassengerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightsComboBox);
            this.Name = "CreateOrderForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.CreateOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox flightsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchPassengerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox chosenSeatComboBox;
        private System.Windows.Forms.ComboBox selectPassengerComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isNewPassengerCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createPassengerButton;
    }
}