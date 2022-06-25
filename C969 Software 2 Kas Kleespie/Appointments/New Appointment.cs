using C969_Software_2_Kas_Kleespie.Models;
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
    public partial class Add_Appointment : Form
    {
        //C. Add Appointment
        public string dataString = SQLHelper.getDataString();
        public Add_Appointment()
        {
            InitializeComponent();
            endDateTime.Value = endDateTime.Value.AddHours(1);
            SQLHelper.getDateTime();
            fillCustomer();
        }
        public Home mainFormObject;


        public void fillCustomer()
        {
            MySqlConnection conn = new MySqlConnection(SQLHelper.dataString);

            try
            {
                string query = "SELECT customerId, concat(customerName, ' -- ID: ', customerId) as Display FROM customer;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Cust");
                cusComboBox.DisplayMember = "Display";
                cusComboBox.ValueMember = "customerId";
                cusComboBox.DataSource = ds.Tables["Cust"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }
        
        public int validAppt(DateTime start, DateTime end)
        {
            DateTime localStart = start.ToLocalTime();
            DateTime localEnd = end.ToLocalTime();

            DateTime businessStart = DateTime.Today.AddHours(8);
            DateTime businessEnd = DateTime.Today.AddHours(17);

            if (localStart.TimeOfDay < businessStart.TimeOfDay || localEnd.TimeOfDay > businessEnd.TimeOfDay)
            {
                return 1;
            }
            if (SQLHelper.AppointmentConflict(start, end) != 0)
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

        private bool validator()
        {
            if (emptyCheck() == false)
            {
                MessageBox.Show("All Appointment Fields must be filled out.");
                return false;
            }
            if (cusComboBox.SelectedIndex == -1)
            {
                comboErrorMsg(customerIDLabel.Text);
                return false;
            }
            if (typecomboBox.SelectedIndex == -1)
            {
                comboErrorMsg(typeLabel.Text);
                return false;
            }
            
            return true;
        }

        private void errorMsg(string item)
        {
            MessageBox.Show("Please enter a valid information for " + item);
        }

        private void comboErrorMsg(string item)
        {
            MessageBox.Show("Please select a valid choice for " + item);
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
                if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    if (combo.SelectedIndex == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
       
        
        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool pass = validator();

            if (pass)
            {
                if (cusComboBox.SelectedItem != null)
                {
                    
                    int custID = Convert.ToInt32(cusComboBox.SelectedValue);

                    DateTime start = startDateTime.Value.ToUniversalTime();
                    DateTime end = endDateTime.Value.ToUniversalTime();

                    //F. Exception Handling for Appointments 
                    int validated = validAppt(start, end);

                    switch (validated)
                    {
                        case 1:
                            MessageBox.Show("This appointment must be scheduled between 8AM and 5PM.");
                            break;

                        case 2:
                            MessageBox.Show("This appointment overlaps with another scheduled appointment.");
                            break;

                        case 3:
                            MessageBox.Show("This appointment starts after the end time.");
                            break;

                        case 4:
                            MessageBox.Show("This appointment must be start and end on the same date.");
                            break;

                        default:
                            SQLHelper.CreateAppointment(custID, titleTextBox.Text, descriptionTextBox.Text, locationTextBox.Text, contactTextBox.Text, typecomboBox.SelectedItem.ToString(), urlTextBox.Text, start, end);
                            MessageBox.Show("The Appointment was created successfully.", "Success");
                            this.Hide();
                            Home home = new Home();
                            home.Show();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("A customer must be selected!");
            }
        }

        private void typecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Uses collections to select option
            SQLHelper.ApptTypeCombo = typecomboBox.Text;
            
        }
    }
    
}
