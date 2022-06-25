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
    public partial class Modify_Appointment : Form
    {
        public static List<KeyValuePair<string, object>> AppointList;

        //C. Update Appointment
        public Modify_Appointment()
        {
            InitializeComponent();
            fillAppoint();
            
        }
        public void setAppointList(List<KeyValuePair<string, object>> list)
        {

            AppointList = list;

        }

        public static List<KeyValuePair<string, object>> getAppointList()
        {

            return AppointList;
        }
        public void fillCustomer(int custID)
        {
            MySqlConnection conn = new MySqlConnection(SQLHelper.dataString);

            try
            {
                string query = "SELECT customerId, customerName as Display FROM customer;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Cust");
                cusComboBox.DisplayMember = "Display";
                cusComboBox.ValueMember = "customerId";
                cusComboBox.DataSource = ds.Tables["Cust"];
                DataRowView drv = cusComboBox.SelectedItem as DataRowView;
                cusComboBox.SelectedValue = custID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }
        public void fillAppoint()
        {
            MySqlConnection conn = new MySqlConnection(SQLHelper.getDataString());

            try
            {
                string query = "SELECT appointmentId, concat(appointmentId, (select concat (' Title: ', title, ' Customer: ', customerName) from customer where appointment.customerId = customer.customerId)) as Display FROM appointment;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Appoint");
                apptComboBox.DisplayMember = "Display";
                apptComboBox.ValueMember = "appointmentId";
                apptComboBox.DataSource = ds.Tables["Appoint"];

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured! " + ex);
            }
        }

        private void Modify_Appointment_Load(object sender, EventArgs e)
        {
           
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void typecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SQLHelper.ApptTypeCombo = typecomboBox.Text;
        }
        
        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool pass = validator();
            if (pass)
            {
                DialogResult youSure = MessageBox.Show("Are you sure you want to update this Appointment?", "", MessageBoxButtons.YesNo);
                if (youSure == DialogResult.Yes)
                {
                    try
                    {
                        var list = getAppointList();
                        IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                        dictionary["customerId"] = cusComboBox.SelectedValue;
                        dictionary["title"] = titleTextBox.Text;
                        dictionary["description"] = descriptionTextBox.Text;
                        dictionary["location"] = locationTextBox.Text;
                        dictionary["contact"] = contactTextBox.Text;
                        dictionary["url"] = urlTextBox.Text;
                        dictionary["type"] = typecomboBox.SelectedItem.ToString();
                        dictionary["start"] = startDateTime.Value;
                        dictionary["end"] = endDateTime.Value;
                        

                        DateTime start = startDateTime.Value.ToUniversalTime();
                        DateTime end = endDateTime.Value.ToUniversalTime();

                        int validated = appointmentValid(start, end);

                        //F. Exception Handling for Appointments 
                        switch (validated)
                        {
                            case 1:
                                MessageBox.Show("This appointment does not fall within business hours.");
                                break;
                            case 2:
                                MessageBox.Show("This appointment overlaps with another appointment.");
                                break;
                            case 3:
                                MessageBox.Show("This appointment starts after the end time.");
                                break;
                            case 4:
                                MessageBox.Show("This appointment start and end date are not on the same date.");
                                break;
                            default:
                                // Pass the updated IDictionary to dbhelper to update the database
                                SQLHelper.UpdateAppointment(dictionary);
                                MessageBox.Show("Customer Record Updated");
                                this.Hide();
                                Home home = new Home();
                                home.Show();
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error occured! " + ex);
                    }
                }
            }

            
        }
        public int appointmentValid(DateTime start, DateTime end)
        {
            DateTime localStart = start.ToLocalTime();
            DateTime localEnd = end.ToLocalTime();

            DateTime businessStart = DateTime.Today.AddHours(8);
            DateTime businessEnd = DateTime.Today.AddHours(17);

            if (localStart.TimeOfDay < businessStart.TimeOfDay || localEnd.TimeOfDay > businessEnd.TimeOfDay)
            {
                return 1;
            }
            if (SQLHelper.overlap(start, end) != 0)
            {
                return 2;
            }
            if (localStart.TimeOfDay > localEnd.TimeOfDay)
            {
                return 3;
            }
            if (localStart.ToShortDateString() != localEnd.ToShortDateString())
            {
                return 4;
            }
            return 0;
        }
        private void enabling(bool status)
        {
            cusComboBox.Enabled = status;
            titleTextBox.Enabled = status;
            descriptionTextBox.Enabled = status;
            locationTextBox.Enabled = status;
            contactTextBox.Enabled = status;
            urlTextBox.Enabled = status;
            typecomboBox.Enabled = status;
            startDateTime.Enabled = status;
            endDateTime.Enabled = status;
            confirmButton.Enabled = status;
        }

        private void fillFields(List<KeyValuePair<string, object>> AppointList)
        {
            // Uses Lambda to set text values from kvp
            titleTextBox.Text = AppointList.First(kvp => kvp.Key == "title").Value.ToString();
            descriptionTextBox.Text = AppointList.First(kvp => kvp.Key == "description").Value.ToString();
            locationTextBox.Text = AppointList.First(kvp => kvp.Key == "location").Value.ToString();
            contactTextBox.Text = AppointList.First(kvp => kvp.Key == "contact").Value.ToString();
            //urlTextBox.Text = AppointList.First(kvp => kvp.Key == "url").Value.ToString();
            typecomboBox.SelectedIndex = typecomboBox.FindStringExact(AppointList.First(kvp => kvp.Key == "type").Value.ToString());
            string start = AppointList.First(kvp => kvp.Key == "start").Value.ToString();
            string end = AppointList.First(kvp => kvp.Key == "end").Value.ToString();

            var list = getAppointList();
            //Uses Lambda to set time values from kvp
            IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
            startDateTime.Value = TimeZone.CurrentTimeZone.ToLocalTime((DateTime)dictionary["start"]);
            endDateTime.Value = TimeZone.CurrentTimeZone.ToLocalTime((DateTime)dictionary["end"]);
        }

        private bool validator()
        {

            if (emptyCheck() == false)
            {
                MessageBox.Show("Please complete all Appointment Information fields.");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(titleTextBox.Text, "[^a-zA-Z]+$"))
            {
                showError(titleLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(descriptionTextBox.Text, "[^a-zA-Z]+$"))
            {
                showError(descriptionLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(locationTextBox.Text, "[^a-zA-Z]+$"))
            {
                showError(locationLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(contactTextBox.Text, "[^a-zA-Z]+$"))
            {
                showError(contactLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(urlTextBox.Text, "[^a-zA-Z]+$"))
            {
                showError(urlLabel.Text);
                return false;
            }
            if (typecomboBox.SelectedIndex == -1)
            {
                showError(typeLabel.Text);
                return false;
            }
            if (cusComboBox.SelectedIndex == -1)
            {
                showError(customerIDLabel.Text);
                return false;
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

        private void searchIDButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = apptComboBox.SelectedItem as DataRowView;
            int id = Convert.ToInt32(apptComboBox.SelectedValue);

            var appointList = SQLHelper.searchAppointment(id);

            setAppointList(appointList);


            if (appointList != null)
            {
                enabling(true);
                fillFields(appointList);
                fillCustomer(Convert.ToInt32(appointList.First(kvp => kvp.Key == "customerId").Value.ToString()));
            }
        }
    }
}
