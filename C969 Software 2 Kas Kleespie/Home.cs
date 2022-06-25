using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Software_2_Kas_Kleespie
{
    public partial class Home : Form
    {
        public static string dataString = SQLHelper.getDataString();
        
        public Home()
        {
            InitializeComponent();
            
            dgvFormatter(customersDataGrid);
            dgvFormatter(apptDataGrid);
            apptDataGrid.Update();
            apptDataGrid.Refresh();
            customersDataGrid.Update();
            customersDataGrid.Refresh();
            Home_Load(weekRadioButton.Checked = true);
            
        }
        public static void dgvFormatter(DataGridView dgvStyle)
        {
            dgvStyle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStyle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStyle.MultiSelect = false;
            dgvStyle.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dgvStyle.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvStyle.ReadOnly = true;

        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newApptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newAppt = new Add_Appointment();
            newAppt.Show();


        }

        private void updateApptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form updateAppt = new Modify_Appointment();
            updateAppt.Show();
        }

        //C. Delete Appointment
        private void deleteApptButton_Click(object sender, EventArgs e)
        {
            
            DataTable dd = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(SQLHelper.dataString))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                dd.Load(reader);

                cn.Close();
            }
            try
            {
                int xyz = (int)dd.Rows[SQLHelper.CurrentApptIndex]["appointmentId"];
                string Query = "DELETE from appointment where appointmentId= '" + xyz + "';";
                MySqlConnection Conn2 = new MySqlConnection(SQLHelper.dataString);
                MySqlCommand Command2 = new MySqlCommand(Query, Conn2);
                MySqlDataReader MyReader2;
                Conn2.Open();
                MyReader2 = Command2.ExecuteReader();
                MessageBox.Show("Appointment has been deleted.");
                while (MyReader2.Read())
                {
                }
                Conn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }

            DataTable dt = new DataTable();
            using (MySqlConnection cnl = new MySqlConnection(SQLHelper.dataString))
            {
                cnl.Open();
                MySqlCommand cmld = new MySqlCommand("SELECT appointmentId, customerId, type, start, end from appointment", cnl);
                MySqlDataReader reader = cmld.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    apptDataGrid.DataSource = dt;
                }
                cnl.Close();

            }
        }

        private void apptDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLHelper.CurrentApptIndex = e.RowIndex;
           
        }

        private void customersDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLHelper.CurrentCusIndex = e.RowIndex;
            
            DataTable ct = new DataTable();
            using (MySqlConnection con = new MySqlConnection(SQLHelper.dataString))
            {
                con.Open();
                MySqlCommand cmmd = new MySqlCommand("SELECT * FROM customer", con);
                MySqlDataReader creader = cmmd.ExecuteReader();
                ct.Load(creader);

                if (ct.Rows.Count > 0)
                {
                    int cxid = (int)ct.Rows[SQLHelper.CurrentCusIndex]["customerId"];
                    SQLHelper.CustID1 = cxid;
                }

                con.Close();
            }
        }
                
        //B. Delete Customer
        private void deletCusButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form updateCus = new Modify_Customer();
            updateCus.Show();
           
        }

        private void updateCusButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form updateCus = new Modify_Customer();
            updateCus.Show();
        }

        private void newCusButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newCus = new Add_Customer();
            newCus.Show();
        }
        private void consultantButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form schedule = new Schedule();
            schedule.Show();
        }
        
        private void activeCusButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form activeCus = new Customer_Report();
            activeCus.Show();
        }

        private void numApptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form numAppt = new numappt();
            numAppt.Show();
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            userNameLabel.Text = (SQLHelper.GetCurrentUserName() + "!");
            //Load Appointments
            DataTable xt = new DataTable();
            using (MySqlConnection cn = new MySqlConnection(SQLHelper.dataString))
            {
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, customerId, type, start, end from appointment", cn);
                MySqlDataReader reader = cmd.ExecuteReader();
                xt.Load(reader);
                if (xt.Rows.Count > 0)
                {
                    for (int idx = 0; idx < xt.Rows.Count; idx++)
                    {
                        xt.Rows[idx]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)xt.Rows[idx]["start"], TimeZoneInfo.Local).ToString();
                        xt.Rows[idx]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)xt.Rows[idx]["end"], TimeZoneInfo.Local).ToString();
                    }
                    apptDataGrid.DataSource = xt;
                }
                cn.Close();

            }
            //Load Customers
            DataTable ct = new DataTable();
            using (MySqlConnection con = new MySqlConnection(SQLHelper.dataString))
            {
                con.Open();
                MySqlCommand cmmd = new MySqlCommand("SELECT customerId, customerName, lastUpdate from customer", con);
                MySqlDataReader creader = cmmd.ExecuteReader();
                ct.Load(creader);

                if (ct.Rows.Count > 0)
                {
                    customersDataGrid.DataSource = ct;
                }
                con.Close();

            }
        }
        
        //D. Filter/view appointments by week and month
        public void Home_Load(bool week)
        {
            DateTime filter = week ? CalcDateFilter("week") : CalcDateFilter("month");
            DataTable dtRecord = SQLHelper.filterCalendar(SQLHelper.DateSQLFormat(filter), week);
            apptDataGrid.DataSource = dtRecord;
        }
        public static DateTime CalcDateFilter(string type)
        {
            if (type == "week")
            {
                DateTime week = DateTime.Now.AddDays(7);
                return week;
            }
            else
            {
                DateTime month = DateTime.Now.AddMonths(1);
                return month;
            }
        }
        public void updateCalendar()
        {
            Home_Load(weekRadioButton.Checked);
        }
        private void weekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Home_Load(weekRadioButton.Checked);
        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateCalendar();
        }

        private void logReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_Report log = new Log_Report();
            log.Show();
        }
    }
}
