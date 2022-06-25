
namespace C969_Software_2_Kas_Kleespie
{
    partial class Schedule
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
            this.label1 = new System.Windows.Forms.Label();
            this.updateApptLabel = new System.Windows.Forms.Label();
            this.consultantComboBox = new System.Windows.Forms.ComboBox();
            this.genButton = new System.Windows.Forms.Button();
            this.scheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultant:";
            // 
            // updateApptLabel
            // 
            this.updateApptLabel.AutoSize = true;
            this.updateApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateApptLabel.Location = new System.Drawing.Point(26, 18);
            this.updateApptLabel.Name = "updateApptLabel";
            this.updateApptLabel.Size = new System.Drawing.Size(86, 20);
            this.updateApptLabel.TabIndex = 31;
            this.updateApptLabel.Text = "Schedule";
            // 
            // consultantComboBox
            // 
            this.consultantComboBox.FormattingEnabled = true;
            this.consultantComboBox.Location = new System.Drawing.Point(118, 56);
            this.consultantComboBox.Name = "consultantComboBox";
            this.consultantComboBox.Size = new System.Drawing.Size(201, 24);
            this.consultantComboBox.TabIndex = 32;
            this.consultantComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(325, 53);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(107, 28);
            this.genButton.TabIndex = 72;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // scheduleDataGrid
            // 
            this.scheduleDataGrid.AllowUserToAddRows = false;
            this.scheduleDataGrid.AllowUserToDeleteRows = false;
            this.scheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGrid.Location = new System.Drawing.Point(39, 91);
            this.scheduleDataGrid.Name = "scheduleDataGrid";
            this.scheduleDataGrid.ReadOnly = true;
            this.scheduleDataGrid.RowHeadersWidth = 51;
            this.scheduleDataGrid.RowTemplate.Height = 24;
            this.scheduleDataGrid.Size = new System.Drawing.Size(392, 219);
            this.scheduleDataGrid.TabIndex = 73;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(340, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(92, 28);
            this.backButton.TabIndex = 74;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 343);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.scheduleDataGrid);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.consultantComboBox);
            this.Controls.Add(this.updateApptLabel);
            this.Controls.Add(this.label1);
            this.Name = "Schedule";
            this.Text = "Schedule Report";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label updateApptLabel;
        private System.Windows.Forms.ComboBox consultantComboBox;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.DataGridView scheduleDataGrid;
        private System.Windows.Forms.Button backButton;
    }
}