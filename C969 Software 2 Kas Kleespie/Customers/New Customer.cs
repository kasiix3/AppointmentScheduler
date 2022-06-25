using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Software_2_Kas_Kleespie
{
    public partial class Add_Customer : Form
    {
        //B. Add Customer
        public Add_Customer()
        {
            InitializeComponent();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

            bool pass = validator();
            if (pass)
            {
                int countryID;
                if (SQLHelper.CountryExists(countryTextBox.Text.ToLower()) == false)
                {
                    //must create a new country record if it does not already exist
                    countryID = SQLHelper.CreateCountry(countryTextBox.Text);
                }
                else
                {
                    countryID = SQLHelper.GetCountryID(countryTextBox.Text.ToLower());
                }

                int cityID;
                if (SQLHelper.CityExists(cityTextBox.Text.ToLower()) == false)
                {
                    //must create a new city record if it does not already exist
                    cityID = SQLHelper.CreateCity(countryID, cityTextBox.Text);
                }
                else
                {
                    cityID = SQLHelper.GetCityID(cityTextBox.Text.ToLower());
                }

                
                var address2 = "not needed";
                var zip = "not needed";
                int addressID = SQLHelper.CreateAddress(cityID, addressTextBox.Text, address2, zip, phoneTextBox.Text);
                
                SQLHelper.CreateCustomer(SQLHelper.GetID("customer", "customerId") + 1, nameTextBox.Text, addressID, yesRadio.Checked ? 1 : 0, SQLHelper.Create_Timestamp(), SQLHelper.GetCurrentUserName());

                MessageBox.Show("Customer Created successfully!", "Success!");

                this.Hide();
                Home home = new Home();
                home.Show();
            }


        }
        //F. Nonexistent/invalid data
        private bool validator()
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(nameTextBox.Text, "[^a-zA-Z]+$"))
            {
                showError(namelabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(phoneTextBox.Text, "[^0-9-()]+$"))
            {
                showError(phonelabel.Text);
                return false;
            }
            
            var textBoxes = new List<string> { nameTextBox.Text, phoneTextBox.Text, addressTextBox.Text, cityTextBox.Text, countryTextBox.Text };
            foreach (string value in textBoxes)
            {
                if (value.Length < 1)
                {
                    MessageBox.Show("Please complete all fields.");
                    return false;
                }
            }
            return true;
        }

        private void showError(string item)
        {
            MessageBox.Show("Please enter valid information for " + item);

        }

    }
}
