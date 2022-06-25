
namespace C969_Software_2_Kas_Kleespie
{
    partial class Add_Customer
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
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.newCusLabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.citylabel = new System.Windows.Forms.Label();
            this.countrylabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.activeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newCusLabel
            // 
            this.newCusLabel.AutoSize = true;
            this.newCusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCusLabel.Location = new System.Drawing.Point(26, 18);
            this.newCusLabel.Name = "newCusLabel";
            this.newCusLabel.Size = new System.Drawing.Size(132, 20);
            this.newCusLabel.TabIndex = 25;
            this.newCusLabel.Text = "New Customer";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(37, 56);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(45, 17);
            this.namelabel.TabIndex = 26;
            this.namelabel.Text = "Name";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Location = new System.Drawing.Point(37, 95);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(49, 17);
            this.phonelabel.TabIndex = 27;
            this.phonelabel.Text = "Phone";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(37, 134);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(60, 17);
            this.addresslabel.TabIndex = 28;
            this.addresslabel.Text = "Address";
            // 
            // citylabel
            // 
            this.citylabel.AutoSize = true;
            this.citylabel.Location = new System.Drawing.Point(37, 211);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(31, 17);
            this.citylabel.TabIndex = 29;
            this.citylabel.Text = "City";
            // 
            // countrylabel
            // 
            this.countrylabel.AutoSize = true;
            this.countrylabel.Location = new System.Drawing.Point(37, 254);
            this.countrylabel.Name = "countrylabel";
            this.countrylabel.Size = new System.Drawing.Size(57, 17);
            this.countrylabel.TabIndex = 30;
            this.countrylabel.Text = "Country";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(103, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(240, 22);
            this.nameTextBox.TabIndex = 31;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(103, 90);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(240, 22);
            this.phoneTextBox.TabIndex = 32;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(103, 131);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(240, 60);
            this.addressTextBox.TabIndex = 33;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(103, 206);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(240, 22);
            this.cityTextBox.TabIndex = 34;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(103, 249);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(240, 22);
            this.countryTextBox.TabIndex = 35;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(242, 327);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(101, 32);
            this.createButton.TabIndex = 36;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(103, 327);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(101, 32);
            this.cancelButton.TabIndex = 37;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Location = new System.Drawing.Point(126, 286);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(53, 21);
            this.yesRadio.TabIndex = 38;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Location = new System.Drawing.Point(242, 286);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(47, 21);
            this.noRadio.TabIndex = 39;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(40, 290);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(54, 17);
            this.activeLabel.TabIndex = 40;
            this.activeLabel.Text = "Active?";
            // 
            // Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 385);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.noRadio);
            this.Controls.Add(this.yesRadio);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.countrylabel);
            this.Controls.Add(this.citylabel);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.newCusLabel);
            this.Name = "Add_Customer";
            this.Text = "New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label newCusLabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.Label citylabel;
        private System.Windows.Forms.Label countrylabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.Label activeLabel;
    }
}