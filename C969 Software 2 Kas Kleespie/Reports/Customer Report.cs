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
    public partial class Customer_Report : Form
    {
        //I. Report for active customers (choice of report)
        public Customer_Report()
        {
            InitializeComponent();
            dgvFormatter(activeDGV);

            
            DataTable ct = new DataTable();
            using (MySqlConnection con = new MySqlConnection(SQLHelper.dataString))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT customerId, customerName, createDate, lastUpdate from customer where active =1;", con);
                MySqlDataReader creader = cmd.ExecuteReader();
                ct.Load(creader);

                if (ct.Rows.Count > 0)
                {
                    activeDGV.DataSource = ct;
                }
                con.Close();


            }

        }
        public static void dgvFormatter(DataGridView dgvStyle)
        {
            dgvStyle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStyle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStyle.MultiSelect = false;
            dgvStyle.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple;
            dgvStyle.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dgvStyle.ReadOnly = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
