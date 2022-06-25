using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Software_2_Kas_Kleespie.Models
{
    class Customer
    {
        public int CustID { get; set; }
        public string CustName { get; set; }
        public int AddressID { get; set; }
        public string Active { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
       
        public string Phone { get; set; }
        public DateTime CcreateDate { get; set; }
        public string CcreatedBy { get; set; }
        public DateTime ClastUpdate { get; set; }
        public string ClastUpdateBy { get; set; }

        public Customer(int custID, string custname, int addressID, string active, string address, string city,
          string phone, DateTime ccreatedate, string ccreatedby, DateTime clastupdate,
            string clastupdateby)
        {
            CustID = custID;
            CustName = custname;
            AddressID = addressID;
            Active = active;
            Address = address;
            City = city;
            Phone = phone;
            CcreateDate = ccreatedate;
            CcreatedBy = ccreatedby;
            ClastUpdate = clastupdate;
            ClastUpdateBy = clastupdateby;
        }
    }
}
