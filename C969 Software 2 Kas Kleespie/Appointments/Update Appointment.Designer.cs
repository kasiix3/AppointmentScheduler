
namespace C969_Software_2_Kas_Kleespie
{
    partial class Modify_Appointment
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
            this.updateApptLabel = new System.Windows.Forms.Label();
            this.typecomboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endDateTime = new System.Windows.Forms.DateTimePicker();
            this.startDateTime = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.cusComboBox = new System.Windows.Forms.ComboBox();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.apptComboBox = new System.Windows.Forms.ComboBox();
            this.apptIDLabel = new System.Windows.Forms.Label();
            this.searchIDButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateApptLabel
            // 
            this.updateApptLabel.AutoSize = true;
            this.updateApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateApptLabel.Location = new System.Drawing.Point(20, 15);
            this.updateApptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.updateApptLabel.Name = "updateApptLabel";
            this.updateApptLabel.Size = new System.Drawing.Size(155, 17);
            this.updateApptLabel.TabIndex = 29;
            this.updateApptLabel.Text = "Update Appointment";
            // 
            // typecomboBox
            // 
            this.typecomboBox.FormattingEnabled = true;
            this.typecomboBox.Items.AddRange(new object[] {
            "Scrum",
            "Presentation",
            "Meeting"});
            this.typecomboBox.Location = new System.Drawing.Point(81, 312);
            this.typecomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typecomboBox.Name = "typecomboBox";
            this.typecomboBox.Size = new System.Drawing.Size(240, 21);
            this.typecomboBox.TabIndex = 43;
            this.typecomboBox.SelectedIndexChanged += new System.EventHandler(this.typecomboBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(40, 315);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 41;
            this.typeLabel.Text = "Type";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(38, 391);
            this.endTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.endTimeLabel.TabIndex = 39;
            this.endTimeLabel.Text = "End Time";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(38, 345);
            this.startTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.startTimeLabel.TabIndex = 38;
            this.startTimeLabel.Text = "Start Time";
            // 
            // endDateTime
            // 
            this.endDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTime.Location = new System.Drawing.Point(40, 407);
            this.endDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(282, 20);
            this.endDateTime.TabIndex = 37;
            // 
            // startDateTime
            // 
            this.startDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTime.Location = new System.Drawing.Point(40, 362);
            this.startDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(282, 20);
            this.startDateTime.TabIndex = 36;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(134, 449);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 28);
            this.cancelButton.TabIndex = 34;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(231, 449);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(90, 28);
            this.confirmButton.TabIndex = 33;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(78, 280);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(242, 20);
            this.urlTextBox.TabIndex = 57;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(24, 284);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(54, 13);
            this.urlLabel.TabIndex = 56;
            this.urlLabel.Text = "URL/Link";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(78, 175);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(242, 44);
            this.descriptionTextBox.TabIndex = 55;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(19, 185);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 54;
            this.descriptionLabel.Text = "Description";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(78, 152);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(242, 20);
            this.titleTextBox.TabIndex = 53;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(31, 156);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 52;
            this.titleLabel.Text = "Title";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(78, 223);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(242, 20);
            this.locationTextBox.TabIndex = 51;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(31, 225);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 50;
            this.locationLabel.Text = "Location";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(78, 252);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(242, 20);
            this.contactTextBox.TabIndex = 49;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(31, 256);
            this.contactLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(44, 13);
            this.contactLabel.TabIndex = 48;
            this.contactLabel.Text = "Contact";
            // 
            // cusComboBox
            // 
            this.cusComboBox.FormattingEnabled = true;
            this.cusComboBox.Location = new System.Drawing.Point(108, 122);
            this.cusComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cusComboBox.Name = "cusComboBox";
            this.cusComboBox.Size = new System.Drawing.Size(212, 21);
            this.cusComboBox.TabIndex = 47;
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(34, 124);
            this.customerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.customerIDLabel.TabIndex = 46;
            this.customerIDLabel.Text = "Customer ID";
            // 
            // apptComboBox
            // 
            this.apptComboBox.FormattingEnabled = true;
            this.apptComboBox.Location = new System.Drawing.Point(100, 42);
            this.apptComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.apptComboBox.Name = "apptComboBox";
            this.apptComboBox.Size = new System.Drawing.Size(212, 21);
            this.apptComboBox.TabIndex = 59;
            // 
            // apptIDLabel
            // 
            this.apptIDLabel.AutoSize = true;
            this.apptIDLabel.Location = new System.Drawing.Point(16, 45);
            this.apptIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apptIDLabel.Name = "apptIDLabel";
            this.apptIDLabel.Size = new System.Drawing.Size(80, 13);
            this.apptIDLabel.TabIndex = 58;
            this.apptIDLabel.Text = "Appointment ID";
            // 
            // searchIDButton
            // 
            this.searchIDButton.Location = new System.Drawing.Point(183, 94);
            this.searchIDButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchIDButton.Name = "searchIDButton";
            this.searchIDButton.Size = new System.Drawing.Size(137, 24);
            this.searchIDButton.TabIndex = 60;
            this.searchIDButton.Text = "Select Appointment";
            this.searchIDButton.UseVisualStyleBackColor = true;
            this.searchIDButton.UseWaitCursor = true;
            this.searchIDButton.Click += new System.EventHandler(this.searchIDButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.ForeColor = System.Drawing.Color.MediumOrchid;
            this.IDLabel.Location = new System.Drawing.Point(18, 71);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(191, 13);
            this.IDLabel.TabIndex = 61;
            this.IDLabel.Text = "Must select for appointment to fill fields.";
            // 
            // Modify_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 491);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.searchIDButton);
            this.Controls.Add(this.apptComboBox);
            this.Controls.Add(this.apptIDLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.cusComboBox);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.typecomboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(this.startDateTime);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.updateApptLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Modify_Appointment";
            this.Text = "Update Appointment";
            this.Load += new System.EventHandler(this.Modify_Appointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateApptLabel;
        private System.Windows.Forms.ComboBox typecomboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.DateTimePicker endDateTime;
        private System.Windows.Forms.DateTimePicker startDateTime;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.ComboBox cusComboBox;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.ComboBox apptComboBox;
        private System.Windows.Forms.Label apptIDLabel;
        private System.Windows.Forms.Button searchIDButton;
        private System.Windows.Forms.Label IDLabel;
    }
}