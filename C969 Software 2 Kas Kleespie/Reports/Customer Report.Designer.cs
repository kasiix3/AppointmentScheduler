
namespace C969_Software_2_Kas_Kleespie
{
    partial class Customer_Report
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
            this.activeDGV = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // updateApptLabel
            // 
            this.updateApptLabel.AutoSize = true;
            this.updateApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateApptLabel.Location = new System.Drawing.Point(26, 18);
            this.updateApptLabel.Name = "updateApptLabel";
            this.updateApptLabel.Size = new System.Drawing.Size(158, 20);
            this.updateApptLabel.TabIndex = 32;
            this.updateApptLabel.Text = "Active Customers";
            // 
            // activeDGV
            // 
            this.activeDGV.AllowUserToAddRows = false;
            this.activeDGV.AllowUserToDeleteRows = false;
            this.activeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activeDGV.Location = new System.Drawing.Point(39, 91);
            this.activeDGV.Name = "activeDGV";
            this.activeDGV.ReadOnly = true;
            this.activeDGV.RowHeadersWidth = 51;
            this.activeDGV.RowTemplate.Height = 24;
            this.activeDGV.Size = new System.Drawing.Size(392, 219);
            this.activeDGV.TabIndex = 33;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(339, 15);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(92, 28);
            this.backButton.TabIndex = 71;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Customer_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 343);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.activeDGV);
            this.Controls.Add(this.updateApptLabel);
            this.Name = "Customer_Report";
            this.Text = "Active Customers Report";
            ((System.ComponentModel.ISupportInitialize)(this.activeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateApptLabel;
        private System.Windows.Forms.DataGridView activeDGV;
        private System.Windows.Forms.Button backButton;
    }
}