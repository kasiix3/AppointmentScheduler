
namespace C969_Software_2_Kas_Kleespie
{
    partial class Home
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
            this.welcome = new System.Windows.Forms.Label();
            this.deletCusButton = new System.Windows.Forms.Button();
            this.updateCusButton = new System.Windows.Forms.Button();
            this.newCusButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.deleteApptButton = new System.Windows.Forms.Button();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.newApptButton = new System.Windows.Forms.Button();
            this.apptsDGVLabel = new System.Windows.Forms.Label();
            this.apptDataGrid = new System.Windows.Forms.DataGridView();
            this.customersDataGrid = new System.Windows.Forms.DataGridView();
            this.customersDGVLabel = new System.Windows.Forms.Label();
            this.activeCusButton = new System.Windows.Forms.Button();
            this.numApptButton = new System.Windows.Forms.Button();
            this.consultantButton = new System.Windows.Forms.Button();
            this.reportLabel = new System.Windows.Forms.Label();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.selectApptLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.logReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apptDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(26, 19);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(111, 26);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome";
            // 
            // deletCusButton
            // 
            this.deletCusButton.Location = new System.Drawing.Point(856, 336);
            this.deletCusButton.Name = "deletCusButton";
            this.deletCusButton.Size = new System.Drawing.Size(124, 57);
            this.deletCusButton.TabIndex = 1;
            this.deletCusButton.Text = "Delete Customer";
            this.deletCusButton.UseVisualStyleBackColor = true;
            this.deletCusButton.Click += new System.EventHandler(this.deletCusButton_Click);
            // 
            // updateCusButton
            // 
            this.updateCusButton.Location = new System.Drawing.Point(694, 335);
            this.updateCusButton.Name = "updateCusButton";
            this.updateCusButton.Size = new System.Drawing.Size(124, 57);
            this.updateCusButton.TabIndex = 2;
            this.updateCusButton.Text = "Update Customer";
            this.updateCusButton.UseVisualStyleBackColor = true;
            this.updateCusButton.Click += new System.EventHandler(this.updateCusButton_Click);
            // 
            // newCusButton
            // 
            this.newCusButton.Location = new System.Drawing.Point(528, 335);
            this.newCusButton.Name = "newCusButton";
            this.newCusButton.Size = new System.Drawing.Size(124, 57);
            this.newCusButton.TabIndex = 3;
            this.newCusButton.Text = "New Customer";
            this.newCusButton.UseVisualStyleBackColor = true;
            this.newCusButton.Click += new System.EventHandler(this.newCusButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(856, 443);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 30);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deleteApptButton
            // 
            this.deleteApptButton.Location = new System.Drawing.Point(358, 335);
            this.deleteApptButton.Name = "deleteApptButton";
            this.deleteApptButton.Size = new System.Drawing.Size(124, 59);
            this.deleteApptButton.TabIndex = 22;
            this.deleteApptButton.Text = "Delete Appointment";
            this.deleteApptButton.UseVisualStyleBackColor = true;
            this.deleteApptButton.Click += new System.EventHandler(this.deleteApptButton_Click);
            // 
            // updateApptButton
            // 
            this.updateApptButton.Location = new System.Drawing.Point(192, 335);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(124, 59);
            this.updateApptButton.TabIndex = 21;
            this.updateApptButton.Text = "Update Appointment";
            this.updateApptButton.UseVisualStyleBackColor = true;
            this.updateApptButton.Click += new System.EventHandler(this.updateApptButton_Click);
            // 
            // newApptButton
            // 
            this.newApptButton.Location = new System.Drawing.Point(30, 335);
            this.newApptButton.Name = "newApptButton";
            this.newApptButton.Size = new System.Drawing.Size(124, 59);
            this.newApptButton.TabIndex = 20;
            this.newApptButton.Text = "New Appointment";
            this.newApptButton.UseVisualStyleBackColor = true;
            this.newApptButton.Click += new System.EventHandler(this.newApptButton_Click);
            // 
            // apptsDGVLabel
            // 
            this.apptsDGVLabel.AutoSize = true;
            this.apptsDGVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptsDGVLabel.Location = new System.Drawing.Point(27, 59);
            this.apptsDGVLabel.Name = "apptsDGVLabel";
            this.apptsDGVLabel.Size = new System.Drawing.Size(106, 17);
            this.apptsDGVLabel.TabIndex = 19;
            this.apptsDGVLabel.Text = "Appointments";
            // 
            // apptDataGrid
            // 
            this.apptDataGrid.AllowUserToAddRows = false;
            this.apptDataGrid.AllowUserToDeleteRows = false;
            this.apptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptDataGrid.Location = new System.Drawing.Point(30, 98);
            this.apptDataGrid.Name = "apptDataGrid";
            this.apptDataGrid.ReadOnly = true;
            this.apptDataGrid.RowHeadersWidth = 51;
            this.apptDataGrid.RowTemplate.Height = 24;
            this.apptDataGrid.Size = new System.Drawing.Size(452, 217);
            this.apptDataGrid.TabIndex = 18;
            this.apptDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.apptDataGrid_CellContentClick);
            // 
            // customersDataGrid
            // 
            this.customersDataGrid.AllowUserToAddRows = false;
            this.customersDataGrid.AllowUserToDeleteRows = false;
            this.customersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGrid.Location = new System.Drawing.Point(528, 98);
            this.customersDataGrid.Name = "customersDataGrid";
            this.customersDataGrid.ReadOnly = true;
            this.customersDataGrid.RowHeadersWidth = 51;
            this.customersDataGrid.RowTemplate.Height = 24;
            this.customersDataGrid.Size = new System.Drawing.Size(452, 217);
            this.customersDataGrid.TabIndex = 23;
            this.customersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDataGrid_CellContentClick);
            // 
            // customersDGVLabel
            // 
            this.customersDGVLabel.AutoSize = true;
            this.customersDGVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersDGVLabel.Location = new System.Drawing.Point(525, 59);
            this.customersDGVLabel.Name = "customersDGVLabel";
            this.customersDGVLabel.Size = new System.Drawing.Size(84, 17);
            this.customersDGVLabel.TabIndex = 24;
            this.customersDGVLabel.Text = "Customers";
            // 
            // activeCusButton
            // 
            this.activeCusButton.Location = new System.Drawing.Point(310, 421);
            this.activeCusButton.Name = "activeCusButton";
            this.activeCusButton.Size = new System.Drawing.Size(124, 52);
            this.activeCusButton.TabIndex = 25;
            this.activeCusButton.Text = "Active Customers";
            this.activeCusButton.UseVisualStyleBackColor = true;
            this.activeCusButton.Click += new System.EventHandler(this.activeCusButton_Click);
            // 
            // numApptButton
            // 
            this.numApptButton.Location = new System.Drawing.Point(180, 421);
            this.numApptButton.Name = "numApptButton";
            this.numApptButton.Size = new System.Drawing.Size(124, 52);
            this.numApptButton.TabIndex = 29;
            this.numApptButton.Text = "Number of Appointments";
            this.numApptButton.UseVisualStyleBackColor = true;
            this.numApptButton.Click += new System.EventHandler(this.numApptButton_Click);
            // 
            // consultantButton
            // 
            this.consultantButton.Location = new System.Drawing.Point(34, 421);
            this.consultantButton.Name = "consultantButton";
            this.consultantButton.Size = new System.Drawing.Size(140, 52);
            this.consultantButton.TabIndex = 30;
            this.consultantButton.Text = "Consultant Schedule";
            this.consultantButton.UseVisualStyleBackColor = true;
            this.consultantButton.Click += new System.EventHandler(this.consultantButton_Click);
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(31, 401);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(65, 17);
            this.reportLabel.TabIndex = 31;
            this.reportLabel.Text = "Reports";
            // 
            // weekRadioButton
            // 
            this.weekRadioButton.AutoSize = true;
            this.weekRadioButton.Location = new System.Drawing.Point(335, 72);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.Size = new System.Drawing.Size(65, 21);
            this.weekRadioButton.TabIndex = 32;
            this.weekRadioButton.TabStop = true;
            this.weekRadioButton.Text = "Week";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            this.weekRadioButton.CheckedChanged += new System.EventHandler(this.weekRadioButton_CheckedChanged);
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Location = new System.Drawing.Point(406, 72);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(68, 21);
            this.monthRadioButton.TabIndex = 33;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "Month";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            this.monthRadioButton.CheckedChanged += new System.EventHandler(this.monthRadioButton_CheckedChanged);
            // 
            // selectApptLabel
            // 
            this.selectApptLabel.AutoSize = true;
            this.selectApptLabel.ForeColor = System.Drawing.Color.MediumOrchid;
            this.selectApptLabel.Location = new System.Drawing.Point(28, 78);
            this.selectApptLabel.Name = "selectApptLabel";
            this.selectApptLabel.Size = new System.Drawing.Size(257, 17);
            this.selectApptLabel.TabIndex = 35;
            this.selectApptLabel.Text = "Select appointment to update or delete.";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(143, 19);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(0, 26);
            this.userNameLabel.TabIndex = 36;
            // 
            // logReportButton
            // 
            this.logReportButton.Location = new System.Drawing.Point(440, 421);
            this.logReportButton.Name = "logReportButton";
            this.logReportButton.Size = new System.Drawing.Size(124, 52);
            this.logReportButton.TabIndex = 37;
            this.logReportButton.Text = "Log Report";
            this.logReportButton.UseVisualStyleBackColor = true;
            this.logReportButton.Click += new System.EventHandler(this.logReportButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 485);
            this.Controls.Add(this.logReportButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.selectApptLabel);
            this.Controls.Add(this.monthRadioButton);
            this.Controls.Add(this.weekRadioButton);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.consultantButton);
            this.Controls.Add(this.numApptButton);
            this.Controls.Add(this.activeCusButton);
            this.Controls.Add(this.customersDGVLabel);
            this.Controls.Add(this.customersDataGrid);
            this.Controls.Add(this.deleteApptButton);
            this.Controls.Add(this.updateApptButton);
            this.Controls.Add(this.newApptButton);
            this.Controls.Add(this.apptsDGVLabel);
            this.Controls.Add(this.apptDataGrid);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newCusButton);
            this.Controls.Add(this.updateCusButton);
            this.Controls.Add(this.deletCusButton);
            this.Controls.Add(this.welcome);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apptDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button deletCusButton;
        private System.Windows.Forms.Button updateCusButton;
        private System.Windows.Forms.Button newCusButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button deleteApptButton;
        private System.Windows.Forms.Button updateApptButton;
        private System.Windows.Forms.Button newApptButton;
        private System.Windows.Forms.Label apptsDGVLabel;
        private System.Windows.Forms.DataGridView apptDataGrid;
        private System.Windows.Forms.DataGridView customersDataGrid;
        private System.Windows.Forms.Label customersDGVLabel;
        private System.Windows.Forms.Button activeCusButton;
        private System.Windows.Forms.Button numApptButton;
        private System.Windows.Forms.Button consultantButton;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.RadioButton weekRadioButton;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.Label selectApptLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button logReportButton;
    }
}