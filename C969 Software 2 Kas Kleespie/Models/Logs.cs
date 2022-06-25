using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Software_2_Kas_Kleespie
{
    class Logs
    {
        public static string path = "log.txt";
        private static DateTime? _time;
        public static void setTime(DateTime? Time)
        {
            _time = Time;
        }
        public static DateTime? getTime()
        {
            return _time;
        }
        public static void signIn(string userName)
        {
            DateTime time = DateTime.Now.ToLocalTime();
            setTime(time);
            string log = $"User {userName} logged in at {time}" + Environment.NewLine;
            File.AppendAllText(/*Application.StartupPath + */path, log); 
                        
        }


        public static void reminder()
        {
            try
            {

                var list = SQLHelper.getNextAppointInfo();
                //Uses lambda to set values using kvp
                IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                DateTime? timeIn = getTime();
                DateTime? nextAppoint = Convert.ToDateTime(dictionary["start"]);
                string name = dictionary["name"].ToString();
                if (timeIn != null && nextAppoint != null)
                {
                    DateTime dateTime1 = timeIn.Value;
                    DateTime dateTime2 = nextAppoint.Value;
                    TimeSpan diff = dateTime2.Subtract(dateTime1);
                    if (diff.TotalMinutes < 15)
                    {
                        string morning = dateTime2.Hour >= 12 ? " PM " : " AM ";
                        //H. 15 minute alert of next appointment
                        MessageBox.Show("You have an upcoming appointment" + dateTime2.Hour + morning + " with " + name + "!", "Appointment Reminder");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
