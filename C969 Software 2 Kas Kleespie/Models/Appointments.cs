using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Software_2_Kas_Kleespie.Models
{
    class Appointments
    {
        public int ApptID { get; set; }
        public int CustID { get; set; }
        public int UserID { get; set; }
        public string ApptType { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }


        public Appointments(int apptID, int custID, int userID, string apptType, DateTime startTime, DateTime endTime,
            DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            ApptID = apptID;
            CustID = custID;
            UserID = userID;
            ApptType = apptType;
            StartTime = startTime;
            EndTime = endTime;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;

        }
    }
}
