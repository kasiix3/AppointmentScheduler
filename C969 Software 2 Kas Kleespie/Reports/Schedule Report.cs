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
    //I. Schedule report for each consultant [using Test]
    public partial class Schedule : Form
    {
        
        public Schedule()
        {
            InitializeComponent();
            consultantReport();
            dgvFormatter(scheduleDataGrid);
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
       
        public void consultantReport()
        {
            MySqlConnection conn = new MySqlConnection(SQLHelper.getDataString());

            try
            {
                string query = "SELECT userId, userName as Display from user;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "User");
                consultantComboBox.DisplayMember = "Display";
                consultantComboBox.ValueMember = "userId";
                consultantComboBox.DataSource = ds.Tables["User"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void genButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(consultantComboBox.SelectedValue);

            DataTable dtRecord = SQLHelper.schedule(id.ToString());
            scheduleDataGrid.DataSource = dtRecord;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
