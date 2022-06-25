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
    public partial class Modify_Customer : Form
    {
        //B. Update Customer
        public Modify_Customer()
        {
            InitializeComponent();
            fillCustCombo();
            
        }
        public static List<KeyValuePair<string, object>> CustomerList;
        public static List<KeyValuePair<string, object>> getCustList()
        {
            return CustomerList;
        }
        public void setCustList(List<KeyValuePair<string, object>> list)
        {
            CustomerList = list;
        }

        public void fillCustCombo()
        {
            MySqlConnection c = new MySqlConnection(SQLHelper.dataString);

            try
            {
                string query = "SELECT customerId, customerName as Display FROM customer;";
                MySqlDataAdapter data = new MySqlDataAdapter(query, c);
                c.Open();
                DataSet dset = new DataSet();
                data.Fill(dset, "Cust");
                cusComboBox.DisplayMember = "Display";
                cusComboBox.ValueMember = "customerID";
                cusComboBox.DataSource = dset.Tables["Cust"];
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error loading the list of customers" + ex);
            }
        }
        private void fillCust(List<KeyValuePair<string, object>> custList)
        {
            //Lambdas used to set textbox values from kvp
            nameTextBox.Text = custList.First(kvp => kvp.Key == "customerName").Value.ToString();
            phoneTextBox.Text = custList.First(kvp => kvp.Key == "phone").Value.ToString();
            addressTextBox.Text = custList.First(kvp => kvp.Key == "address").Value.ToString();
            cityTextBox.Text = custList.First(kvp => kvp.Key == "city").Value.ToString();
            countryTextBox.Text = custList.First(kvp => kvp.Key == "country").Value.ToString();
            if (Convert.ToInt32(custList.First(kvp => kvp.Key == "active").Value) == 1)
            {
                yesRadio.Checked = true;
            }
            else
            {
                noRadio.Checked = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
;            bool ValidInput = validator();
            if (ValidInput)
            {
                var result = MessageBox.Show("Are you sure you want to update this customer?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Get the customer list
                        var list = getCustList();
                        IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                        // Replace values for the keys in the form
                        dictionary["customerName"] = nameTextBox.Text;
                        dictionary["phone"] = phoneTextBox.Text;
                        dictionary["address"] =addressTextBox.Text;
                        dictionary["city"] = cityTextBox.Text;
                        dictionary["country"] = countryTextBox.Text;
                        dictionary["active"] = yesRadio.Checked ? 1 : 0;

                        //Pass the updated IDictionary to Data.Datahandler to update the database
                        SQLHelper.UpdateCustomer(dictionary);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                   
                }
            }

                this.Hide();
                Home home = new Home();
                home.Show();
            

        }
        private void Control_Enabled(bool status)
        {
            nameTextBox.Enabled = status;
            phoneTextBox.Enabled = status;
            addressTextBox.Enabled = status;
            cityTextBox.Enabled = status;
            countryTextBox.Enabled = status;
            yesRadio.Enabled = status;
            noRadio.Enabled = status;
            updateButton.Enabled = status;
            
        }

        //F. 3 Nonexistent/invalid data
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
            MessageBox.Show("Please enter a valid information for " + item);
        }
        private bool emptyCheck()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void searchIDButton_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cusComboBox.SelectedValue);
            var customerList = SQLHelper.SearchCustomer(id);
            setCustList(customerList);
            if (customerList != null)
            {
                Control_Enabled(true);
                fillCust(customerList);
            }
        }

        private void deleteCusButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var list = getCustList();
                    IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                    // First we need to check if appointments exist
                    bool appoint = SQLHelper.ExistingAppointment(dictionary["customerId"].ToString());
                    if (appoint == false)
                    {
                        SQLHelper.DeleteCustomer(dictionary);
                    }
                    else
                    {
                        DialogResult result_2 = MessageBox.Show("Deleting this customer will delete all appointments scheduled for this customer. Would you like to continue?", "Continue?", MessageBoxButtons.YesNo);
                        if (result_2 == DialogResult.Yes)
                        {
                            SQLHelper.DeleteExistingAppts(dictionary["customerId"].ToString());
                            SQLHelper.DeleteCustomer(dictionary);
                        }
                        else
                        {
                            return;
                        }
                    }
                    MessageBox.Show("The selected customer has been deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
