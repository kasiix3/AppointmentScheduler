
namespace C969_Software_2_Kas_Kleespie
{
    partial class Log_Report
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
            this.backButton = new System.Windows.Forms.Button();
            this.logsDataGrid = new System.Windows.Forms.DataGridView();
            this.logReportLabel = new System.Windows.Forms.Label();
            this.genReportButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(487, 15);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(67, 24);
            this.backButton.TabIndex = 74;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // logsDataGrid
            // 
            this.logsDataGrid.AllowUserToAddRows = false;
            this.logsDataGrid.AllowUserToDeleteRows = false;
            this.logsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logsDataGrid.Location = new System.Drawing.Point(22, 65);
            this.logsDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logsDataGrid.Name = "logsDataGrid";
            this.logsDataGrid.ReadOnly = true;
            this.logsDataGrid.RowHeadersWidth = 51;
            this.logsDataGrid.RowTemplate.Height = 24;
            this.logsDataGrid.Size = new System.Drawing.Size(531, 241);
            this.logsDataGrid.TabIndex = 73;
            // 
            // logReportLabel
            // 
            this.logReportLabel.AutoSize = true;
            this.logReportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logReportLabel.Location = new System.Drawing.Point(20, 15);
            this.logReportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logReportLabel.Name = "logReportLabel";
            this.logReportLabel.Size = new System.Drawing.Size(89, 17);
            this.logReportLabel.TabIndex = 72;
            this.logReportLabel.Text = "Log Report";
            // 
            // genReportButton
            // 
            this.genReportButton.Location = new System.Drawing.Point(378, 15);
            this.genReportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genReportButton.Name = "genReportButton";
            this.genReportButton.Size = new System.Drawing.Size(104, 24);
            this.genReportButton.TabIndex = 75;
            this.genReportButton.Text = "Generate Report";
            this.genReportButton.UseVisualStyleBackColor = true;
            this.genReportButton.Click += new System.EventHandler(this.genReportButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.ForeColor = System.Drawing.Color.MediumOrchid;
            this.IDLabel.Location = new System.Drawing.Point(20, 37);
            this.IDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(138, 13);
            this.IDLabel.TabIndex = 76;
            this.IDLabel.Text = "Generate report to see logs.";
            // 
            // Log_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 328);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.genReportButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logsDataGrid);
            this.Controls.Add(this.logReportLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Log_Report";
            this.Text = "Log_Report";
            ((System.ComponentModel.ISupportInitialize)(this.logsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView logsDataGrid;
        private System.Windows.Forms.Label logReportLabel;
        private System.Windows.Forms.Button genReportButton;
        private System.Windows.Forms.Label IDLabel;
    }
}