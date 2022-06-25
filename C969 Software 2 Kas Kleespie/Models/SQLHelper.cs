using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969_Software_2_Kas_Kleespie
{
    class SQLHelper { 
        public static string dataString = "server=127.0.0.1; database=client_schedule;uid=sqlUser; pwd=Passw0rd!; convert zero datetime=True";
        private static readonly MySqlConnection connection = new MySqlConnection(dataString);
        public static string getDataString()
        {
            return dataString;
        }

        public static int CurrentCusIndex { get; set; }
        public static int CurrentApptIndex { get; set; }
                    
        public static string ApptTypeCombo { get; set; }

        public static int CustID1 { get; set; }
        public static DateTime SelectDate { get; set; }

        private static int _currentUserId;
        private static string _currentUserName;

       
        public static int GetCurrentUserId()
        {
            return _currentUserId;
        }

        public static string GetCurrentUserName()
        {
            return _currentUserName;
        }
        public static void SetCurrentUserId(int currUserId)
        {
            _currentUserId = currUserId;
        }

        public static void SetCurrentUserName(string currUserName)
        {
            _currentUserName = currUserName;
        }
        public static string DateFormat(DateTime dateValue)
        {
            string formatDate = dateValue.ToString("yyyy-MM-dd HH:mm");

            return formatDate;
        }

        // Creates a timestamp to display logs
        public static DateTime Create_Timestamp() => DateTime.Now.ToUniversalTime();

        public static int GetID(string table, string id)
        {
            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();
            var Get_ID_Query = $"SELECT max({id}) FROM {table}";
            MySqlCommand cmd = new MySqlCommand(Get_ID_Query, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                if (rdr[0] == DBNull.Value)
                {
                    return 0;
                }
                return Convert.ToInt32(rdr[0]);
            }
            rdr.Close();
            connection.Close();
            return 0;
        }

        // Get countryId
        public static int GetCountryID(string CountryName)
        {
            int CountryID = 0;
            if (CountryExists(CountryName))
            {
                if (connection.State.ToString() == "Open")
                {
                    connection.Close();
                }
                connection.Open();
                var Get_CountryId_Query = $"SELECT countryId FROM country WHERE LOWER(country) LIKE '%{CountryName}%'";
                MySqlCommand cmd = new MySqlCommand(Get_CountryId_Query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    CountryID = Convert.ToInt32(rdr[0].ToString());
                    rdr.Close();
                }
                connection.Close();
            }
            return CountryID;
        }

        // Get cityId
        public static int GetCityID(string CityName)
        {
            int CityID = 0;
            if (CityExists(CityName))
            {
                if (connection.State.ToString() == "Open")
                {
                    connection.Close();
                }
                connection.Open();
                var Get_CityId_Query = $"SELECT cityId FROM city WHERE LOWER(city) LIKE '%{CityName}%'";
                MySqlCommand cmd = new MySqlCommand(Get_CityId_Query, connection);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    CityID = Convert.ToInt32(rdr[0].ToString());
                    rdr.Close();
                }
                connection.Close();
            }
            return CityID;
        }
       
        public static bool CountryExists(string CountryText)
        {
            var CountryExistsList = new List<string>();
            bool Exists = false;
            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT country FROM country", connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    CountryExistsList.Add(Convert.ToString(rdr["country"]).ToLower());
                }
            }

            if (CountryExistsList.Contains(CountryText))
            {
                Exists = true;
            }
            rdr.Close();
            connection.Close();
            return Exists;
        }

        public static bool CityExists(string CityText)
        {
            var CityExistsList = new List<string>();
            bool Exists = false;
            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT city FROM city", connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    CityExistsList.Add(Convert.ToString(rdr["city"]).ToLower());
                }
            }

            if (CityExistsList.Contains(CityText))
            {
                Exists = true;
            }
            rdr.Close();
            connection.Close();
            return Exists;
        }
        public static void CreateCustomer(int id, string name, int addressId, int active, DateTime dateTime, string user)
        {
            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var Create_Customer_Query = "INSERT into customer (customerId, customerName, addressId, active, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{id}', '{name}',  '{addressId}', '{active}', '{DateFormat(dateTime)}', '{user}', '{user}')";

            MySqlCommand cmd = new MySqlCommand(Create_Customer_Query, connection)
            {
                Transaction = transaction
            };
            cmd.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();
        }

        //Deletes the selected customer
        public static void DeleteCustomer(IDictionary<string, object> dictionary)
        {
            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();
            var Delete_Customer_Query = $"DELETE FROM customer" +
               $" WHERE customerId = '{dictionary["customerId"]}'";
            MySqlCommand cmd = new MySqlCommand(Delete_Customer_Query, connection);
            MySqlTransaction transaction = connection.BeginTransaction();

            cmd.CommandText = Delete_Customer_Query;
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            transaction = connection.BeginTransaction();
            var Delete_Address_Query = $"DELETE FROM address" +
                $" WHERE addressId = '{dictionary["addressId"]}'";
            cmd.CommandText = Delete_Address_Query;
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            transaction = connection.BeginTransaction();
            var Delete_City_Query = $"DELETE FROM city" +
                $" WHERE cityId = '{dictionary["cityId"]}'";
            cmd.CommandText = Delete_City_Query;
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            transaction = connection.BeginTransaction();
            var Delete_Country_Query = $"DELETE FROM country" +
                $" WHERE countryId = '{dictionary["countryId"]}'";
            cmd.CommandText = Delete_Country_Query;
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();
        }

        // Check for existing appointment
        public static bool ExistingAppointment(string custID)
        {
            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM appointment where customerId = '{custID}'", connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                rdr.Close();
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        //Deletes all appointments from the associated customer
        public static void DeleteExistingAppts(string custID)
        {
            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();
            var Remove_Cust_Appt_Query = $"DELETE FROM appointment" +
               $" WHERE customerId = '{custID}'";
            MySqlCommand cmd = new MySqlCommand(Remove_Cust_Appt_Query, connection);
            MySqlTransaction transaction = connection.BeginTransaction();
            cmd.CommandText = Remove_Cust_Appt_Query;
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();
        }

        public static int CreateCountry(string country)
        {
            int countryID = GetID("country", "countryID") + 1;
            string user = GetCurrentUserName();
            DateTime utc = Create_Timestamp();

            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var Create_Country_Query = "INSERT into country (countryID, country, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{countryID}', '{country}', '{DateFormat(utc)}','{user}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(Create_Country_Query, connection)
            {
                Transaction = transaction
            };
            cmd.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();

            return countryID;
        }

        public static int CreateCity(int countryID, string city)
        {
            int cityID = GetID("city", "cityId") + 1;
            string user = GetCurrentUserName();
            DateTime utc = Create_Timestamp();

            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var Create_city_Query = "INSERT into city (cityId, city, countryId, createDate, createdBy, lastUpdateBy) " +
                        $"VALUES ('{cityID}', '{city}', '{countryID}', '{DateFormat(utc)}','{user}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(Create_city_Query, connection)
            {
                Transaction = transaction
            };
            cmd.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();

            return cityID;
        }

        public static int CreateAddress(int cityID, string address, string address2, string postalCode, string phone)
        {
            int addressID = GetID("address", "addressId") + 1;
            string user = GetCurrentUserName();
            DateTime utc = Create_Timestamp();

            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();

            MySqlTransaction transaction = connection.BeginTransaction();

            var Create_Address_Query = "INSERT into address (addressId, address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                        $"VALUES ('{addressID}', '{address}', '{address2}', '{cityID}', '{postalCode}', '{phone}', '{DateFormat(utc)}', '{user}', '{DateFormat(utc)}', '{user}')";
            MySqlCommand cmd = new MySqlCommand(Create_Address_Query, connection)
            {
                Transaction = transaction
            };
            cmd.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();

            return addressID;
        }

        public static void CreateAppointment(int custID, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime endTime)
        {
            int appointID = GetID("appointment", "appointmentId") + 1;
            int userID = GetCurrentUserId();
            string currUser = GetCurrentUserName();

            DateTime utc = Create_Timestamp();
            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();
            MySqlTransaction transaction = connection.BeginTransaction(); ;
            
            var Create_Appointment_Query = "INSERT into appointment (appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                        $"VALUES ('{appointID}', '{custID}', '{userID}', '{title}', '{description}', '{location}', '{contact}', '{type}', '{url}', '{DateFormat(start)}','{DateFormat(endTime)}','{DateFormat(utc)}','{currUser}', '{DateFormat(start)}','{currUser}')";
            MySqlCommand cmd = new MySqlCommand(Create_Appointment_Query, connection)
            {
                Transaction = transaction
            };
            cmd.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();
        }
        
        public static List<KeyValuePair<string, object>> searchAppointment(int appointmentID)
        {
            var list = new List<KeyValuePair<string, object>>();
            //Get customer Table info
            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            var query = $"SELECT * FROM appointment WHERE appointmentId = {appointmentID}";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader rdr = cmd.ExecuteReader();

            try
            {
                if (rdr.HasRows)
                {
                    rdr.Read();
                    list.Add(new KeyValuePair<string, object>("appointmentId", rdr[0]));
                    list.Add(new KeyValuePair<string, object>("customerId", rdr[1]));
                    list.Add(new KeyValuePair<string, object>("title", rdr[3]));
                    list.Add(new KeyValuePair<string, object>("description", rdr[4]));
                    list.Add(new KeyValuePair<string, object>("location", rdr[5]));
                    list.Add(new KeyValuePair<string, object>("contact", rdr[6]));
                    list.Add(new KeyValuePair<string, object>("type", rdr[7]));
                    list.Add(new KeyValuePair<string, object>("start", rdr[9]));
                    list.Add(new KeyValuePair<string, object>("end", rdr[10]));
                    rdr.Close();
                }
                else
                {
                    MessageBox.Show("No Appointment found with the ID: " + appointmentID, "Please try again");
                    return null;
                }

                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public static List<KeyValuePair<string, object>> SearchCustomer(int customerID)
        {
            var list = new List<KeyValuePair<string, object>>();

            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();
            var Search_Customer_Query = $"SELECT * FROM customer WHERE customerId = {customerID}";
            MySqlCommand cmd = new MySqlCommand(Search_Customer_Query, connection);

            MySqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                if (rdr.HasRows)
                {
                    rdr.Read();
                    list.Add(new KeyValuePair<string, object>("customerId", rdr[0]));
                    list.Add(new KeyValuePair<string, object>("customerName", rdr[1]));
                    list.Add(new KeyValuePair<string, object>("addressId", rdr[2]));
                    list.Add(new KeyValuePair<string, object>("active", rdr[3]));
                    rdr.Close();
                }
                else
                {
                    MessageBox.Show("No Customer found with the ID: " + customerID, "Please try again");
                    return null;
                }

                //Get Address info now that we have addressID
                var addressID = list.First(kvp => kvp.Key == "addressId").Value;

                var query2 = $"SELECT * FROM address WHERE addressId = {addressID}";
                cmd.CommandText = query2;
                cmd.Connection = connection;
                MySqlDataReader rdr2 = cmd.ExecuteReader();
                if (rdr2.HasRows)
                {
                    rdr2.Read();
                    list.Add(new KeyValuePair<string, object>("address", rdr2[1]));
                    list.Add(new KeyValuePair<string, object>("cityId", rdr2[3]));
                    list.Add(new KeyValuePair<string, object>("phone", rdr2[5]));
                    rdr2.Close();
                }

                // Get city info now that we have cityID
                var cityID = list.First(kvp => kvp.Key == "cityId").Value;

                var query3 = $"SELECT * FROM city WHERE cityId = {cityID}";
                cmd.CommandText = query3;
                cmd.Connection = connection;
                MySqlDataReader rdr3 = cmd.ExecuteReader();
                if (rdr3.HasRows)
                {
                    rdr3.Read();
                    list.Add(new KeyValuePair<string, object>("city", rdr3[1]));
                    list.Add(new KeyValuePair<string, object>("countryId", rdr3[2]));
                    rdr3.Close();
                }

                //Get country info now that we have countryId
                var countryID = list.First(kvp => kvp.Key == "countryId").Value;

                var query4 = $"SELECT * FROM country WHERE countryId = {countryID}";
                cmd.CommandText = query4;
                cmd.Connection = connection;
                MySqlDataReader rdr4 = cmd.ExecuteReader();
                if (rdr4.HasRows)
                {
                    rdr4.Read();
                    list.Add(new KeyValuePair<string, object>("country", rdr4[1]));
                    rdr4.Close();
                }
                connection.Close();
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
                return null;
            }
        }
        public static Dictionary<string, object> getNextAppointInfo()
        {
            Dictionary<string, object> appointINFO = new Dictionary<string, object>();

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            var query = " Select start, (select customerName from customer where customerId = appointment.customerId ) as 'Name' from appointment  where start > now() order by  start limit 1;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                appointINFO.Add("start", Convert.ToDateTime(rdr[0]).ToLocalTime());
                appointINFO.Add("name", rdr[1]);
            }


            return appointINFO;
        }

        public static int overlap(DateTime start, DateTime end)
        {
            int uId = GetCurrentUserId();
            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            var query = $"SELECT count(*) FROM `appointment` WHERE (('{DateFormat(start.ToUniversalTime())}' < end) and ('{DateFormat(end.ToUniversalTime())}' >= start) AND userId = {uId});"; Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                string count = rdr[0].ToString();
                int result = count == "0" ? 0 : 1;
                return result;
            }
            return 0;
        }
        public static int userCheck(string user, string pass)
        {
            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT userId, userName FROM user where userName = '{user}' AND password = '{pass}'", conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                SetCurrentUserId(Convert.ToInt32(rdr[0]));
                SetCurrentUserName(Convert.ToString(rdr[1]));
                rdr.Close();
                conn.Close();
                return 1;
            }
            conn.Close();
            return 0;
        }
        public static void UpdateCustomer(IDictionary<string, object> dictionary)
        {
            string user = GetCurrentUserName();

            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();

            // Start a country transaction
            MySqlTransaction transaction = connection.BeginTransaction();
            var Update_Country_Query = $"UPDATE country" +
                $" SET country = '{dictionary["country"]}', lastUpdateBy = '{user}'" +
                $" WHERE countryId = '{dictionary["countryId"]}'";
            MySqlCommand cmd = new MySqlCommand(Update_Country_Query, connection)
            {
                Transaction = transaction
            };
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a city transaction.
            transaction = connection.BeginTransaction();
            var Update_City_Query = $"UPDATE city" +
                $" SET city = '{dictionary["city"]}', lastUpdateBy = '{user}'" +
                $" WHERE cityId = '{dictionary["cityId"]}'";
            cmd.CommandText = Update_City_Query;
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a address transaction.
            transaction = connection.BeginTransaction();
            var Update_Address_Query = $"UPDATE address" +
                $" SET address = '{dictionary["address"]}', lastUpdateBy = '{user}', phone = '{dictionary["phone"]}'" +
                $" WHERE addressId = '{dictionary["addressId"]}'";
            cmd.CommandText = Update_Address_Query;
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();

            // Start a customer transaction.
            transaction = connection.BeginTransaction();
            var Update_Customer_Query = $"UPDATE customer" +
                $" SET customerName = '{dictionary["customerName"]}', lastUpdateBy = '{user}', active = '{dictionary["active"]}'" +
                $" WHERE customerId = '{dictionary["customerId"]}'";
            cmd.CommandText = Update_Customer_Query;
            cmd.Connection = connection;
            cmd.Transaction = transaction;
            cmd.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();
        }

        public static void UpdateAppointment(IDictionary<string, object> dictionary)
        {
            string user = GetCurrentUserName();
            DateTime utc = Create_Timestamp();
            DateTime start = Convert.ToDateTime(dictionary["start"]);
            DateTime end = Convert.ToDateTime(dictionary["end"]);
            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();
            MySqlTransaction transaction = connection.BeginTransaction();
            var Update_Appt_Query = $"UPDATE appointment" +
                $" SET customerId = '{dictionary["customerId"]}', title = '{dictionary["title"]}', description = '{dictionary["description"]}', location = '{dictionary["location"]}' , contact = '{dictionary["contact"]}' , " +
                $" type = '{dictionary["type"]}' ,  start = '{DateFormat(start.ToUniversalTime())}' , end = '{DateFormat(end.ToUniversalTime())}' , url = '{dictionary["url"]}' , lastUpdate = '{DateFormat(utc)}',  lastUpdateBy = '{user}' " +
                $" WHERE appointmentId = '{dictionary["appointmentId"]}'";
            MySqlCommand cmd = new MySqlCommand(Update_Appt_Query, connection)
            {
                Transaction = transaction
            };
            cmd.ExecuteNonQuery();
            transaction.Commit();
            connection.Close();
        }
        public static int AppointmentConflict(DateTime start, DateTime end)
        {
            int uId = GetCurrentUserId();
            if (connection.State.ToString() == "Open")
            {
                connection.Close();
            }
            connection.Open();
            var Get_Appt_Conflict_Query = $"SELECT count(*) FROM `appointment` WHERE (('{DateFormat(start.ToUniversalTime())}' < end) and ('{DateFormat(end.ToUniversalTime())}' >= start) AND userId = {uId});";
            MySqlCommand cmd = new MySqlCommand(Get_Appt_Conflict_Query, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                string count = rdr[0].ToString();
                int result = count == "0" ? 0 : 1;
                rdr.Close();
                connection.Close();
                return result;
            }
            connection.Close();
            return 0;
        }


        public static Dictionary<string, object> apptReport(string item)
        {
            Dictionary<string, object> reportINFO = new Dictionary<string, object>();
            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            var query = $"select distinct" +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 1) as 'Jan'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 2) as 'Feb'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 3) as 'Mar'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 4) as 'Apr'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 5) as 'May'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 6) as 'Jun'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 7) as 'Jul'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 8) as 'Aug'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 9) as 'Sep'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 10) as 'Oct'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 11) as 'Nov'," +
                $"                (select count(type) from appointment where type = '{item}' and MONTH(appointment.start) = 12) as 'Dec'" +
                $"            from appointment;";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                reportINFO.Add("Jan", rdr[0]);
                reportINFO.Add("Feb", rdr[1]);
                reportINFO.Add("Mar", rdr[2]);
                reportINFO.Add("Apr", rdr[3]);
                reportINFO.Add("May", rdr[4]);
                reportINFO.Add("Jun", rdr[5]);
                reportINFO.Add("Jul", rdr[6]);
                reportINFO.Add("Aug", rdr[7]);
                reportINFO.Add("Sep", rdr[8]);
                reportINFO.Add("Oct", rdr[9]);
                reportINFO.Add("Nov", rdr[10]);
                reportINFO.Add("Dec", rdr[11]);
            }

            return reportINFO;
        }
        public static Dictionary<string, object> allReport()
        {
            Dictionary<string, object> reportINFO = new Dictionary<string, object>();
            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            var query = $"select distinct" +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 1) as 'Jan'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 2) as 'Feb'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 3) as 'Mar'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 4) as 'Apr'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 5) as 'May'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 6) as 'Jun'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 7) as 'Jul'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 8) as 'Aug'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 9) as 'Sep'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 10) as 'Oct'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 11) as 'Nov'," +
                $"                (select count(type) from appointment where MONTH(appointment.start) = 12) as 'Dec'" +
                $"            from appointment;";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                reportINFO.Add("Jan", rdr[0]);
                reportINFO.Add("Feb", rdr[1]);
                reportINFO.Add("Mar", rdr[2]);
                reportINFO.Add("Apr", rdr[3]);
                reportINFO.Add("May", rdr[4]);
                reportINFO.Add("Jun", rdr[5]);
                reportINFO.Add("Jul", rdr[6]);
                reportINFO.Add("Aug", rdr[7]);
                reportINFO.Add("Sep", rdr[8]);
                reportINFO.Add("Oct", rdr[9]);
                reportINFO.Add("Nov", rdr[10]);
                reportINFO.Add("Dec", rdr[11]);
            }

            return reportINFO;
        }
        public static DataTable filterCalendar(string filter, bool week)
        {

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();
            string query = week ? $"SELECT (select customerName from customer where customerId = appointment.customerId) as 'Customer',  customerId as 'Customer Id', title as 'Title', type as 'Type', start as 'Start Time', end as 'End Time', location as 'Location' FROM appointment where start < '{filter}' and end < '{filter}'  and end > now() order by start;"
                : $"SELECT  (select customerName from customer where customerId = appointment.customerId) as 'Customer', customerId as 'Customer Id', title as 'Title', type as 'Type', start as 'Start Time', end as 'End Time', location as 'Location' FROM appointment where start < '{filter}' and end < '{filter}' and end > now() order by start;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                DateTime utcStart = Convert.ToDateTime(row["Start Time"]);
                DateTime utcEnd = Convert.ToDateTime(row["End Time"]);
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
            }

            conn.Close();
            return dt;

        }
        public static string DateSQLFormat(DateTime dateValue)
        {
            string formatForMySql = dateValue.ToString("yyyy-MM-dd HH:mm");

            return formatForMySql;
        }
        public static DataTable schedule(string id)
        {

            MySqlConnection conn = new MySqlConnection(dataString);
            conn.Open();

            string query = $"SELECT (SELECT customerName FROM customer WHERE customerId = appointment.customerId) as 'Customer',  start as 'Start Time', end as 'End Time', location as 'Location', title as 'Title' FROM appointment where userId = '{id}' order by start;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            foreach (DataRow row in dt.Rows)
            {
                DateTime utcStart = Convert.ToDateTime(row["Start Time"]);
                DateTime utcEnd = Convert.ToDateTime(row["End Time"]);
                row["Start Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcStart);
                row["End Time"] = TimeZone.CurrentTimeZone.ToLocalTime(utcEnd);
            }

            conn.Close();
            return dt;
        }
     
        public static DateTime getDateTime()
        {
            return DateTime.Now.ToUniversalTime();
        }

    }

}

