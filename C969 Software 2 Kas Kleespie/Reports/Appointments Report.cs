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
    //I. Number of appts types per month
    public partial class numappt : Form
    {
        public numappt()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            DataRowView data = typecomboBox.SelectedItem as DataRowView;
            try
            {
                string item = typecomboBox.SelectedItem.ToString();
                IDictionary<string, object> dictionary = SQLHelper.apptReport(item);
                janResult.Text = dictionary["Jan"].ToString();
                febResult.Text = dictionary["Feb"].ToString();
                marchResult.Text = dictionary["Mar"].ToString();
                aprilResult.Text = dictionary["Apr"].ToString();
                mayResult.Text = dictionary["May"].ToString();
                juneResult.Text = dictionary["Jun"].ToString();
                julyResult.Text = dictionary["Jul"].ToString();
                augResult.Text = dictionary["Aug"].ToString();
                septResult.Text = dictionary["Sep"].ToString();
                octResult.Text = dictionary["Oct"].ToString();
                novResult.Text = dictionary["Nov"].ToString();
                decResult.Text = dictionary["Dec"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void allTypesButton_Click(object sender, EventArgs e)
        {
            try
            {
                IDictionary<string, object> dictionary = SQLHelper.allReport();
                janResult.Text = dictionary["Jan"].ToString();
                febResult.Text = dictionary["Feb"].ToString();
                marchResult.Text = dictionary["Mar"].ToString();
                aprilResult.Text = dictionary["Apr"].ToString();
                mayResult.Text = dictionary["May"].ToString();
                juneResult.Text = dictionary["Jun"].ToString();
                julyResult.Text = dictionary["Jul"].ToString();
                augResult.Text = dictionary["Aug"].ToString();
                septResult.Text = dictionary["Sep"].ToString();
                octResult.Text = dictionary["Oct"].ToString();
                novResult.Text = dictionary["Nov"].ToString();
                decResult.Text = dictionary["Dec"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
