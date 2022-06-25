using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Software_2_Kas_Kleespie
{
    public partial class Log_Report : Form
    {
        //J. Track user activity by timestaps in .txt file
        public Log_Report()
        {
            InitializeComponent();
        }

        private void genReportButton_Click(object sender, EventArgs e)
        {
            string[] ReadFile = File.ReadAllLines(/*Application.StartupPath + */Logs.path);
            IList<String> LogData = new List<String>();
            foreach (string x in ReadFile)
            {
                LogData.Add(x);
            }
            if (ReadFile.Length == 0)
            {
                LogData.Add("No current user data to display.");
            }
            logsDataGrid.DataSource = LogData.Select(x => new { Logs = x }).ToList();
            logsDataGrid.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
