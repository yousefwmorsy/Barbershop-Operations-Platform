using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Barbershop_Operations_Platform
{
    internal class Cust_controller
    {
        DBManager dbMan;
        public Cust_controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public DataTable Get_cust_info(int ID)
        {
            string query = "SELECT CONCAT(FNAME,' ',Lname) AS fullname,BDATE ,phone_number,Email,points,haircut_details From Customer where custID=" + ID + ";";
            return (DataTable)dbMan.ExecuteReader(query);
        }
        public int add_customer(string firstname, string lastname, string BDate, string phone, string email, string password)
        {
            string query = "INSERT INTO customer (Fname, Lname, BDate, phone_number, Email, Password) " +
                              "VALUES (@Fname, @Lname, @BDate, @phone_number, @Email, @Password);";

            using (SqlConnection connection = new SqlConnection(dbMan.GetConnectionString() + ";Column Encryption Setting=Enabled;"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.Add("@Fname", SqlDbType.VarChar, 50).Value = firstname;
                command.Parameters.Add("@Lname", SqlDbType.VarChar, 50).Value = lastname;
                command.Parameters.Add("@BDate", SqlDbType.VarChar, 20).Value = BDate;
                command.Parameters.Add("@phone_number", SqlDbType.VarChar, 20).Value = phone;
                command.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = email;

                //el encrypted 
                SqlParameter passwordParameter = new SqlParameter("@Password", SqlDbType.VarChar, 50);
                passwordParameter.Value = password;
                command.Parameters.Add(passwordParameter);


                connection.Open();
                return command.ExecuteNonQuery();

            }
        }
        public int update_cust_info(int ID, string attribute, string value)
        {
            if (attribute == "password")
            {

                string passwordquery = $"UPDATE customer SET password = @NewPassword WHERE {ID} = CustID";
                using (SqlConnection connection = new SqlConnection(dbMan.GetConnectionString() + ";Column Encryption Setting=Enabled;"))
                using (SqlCommand command = new SqlCommand(passwordquery, connection))
                {
                    SqlParameter passwordParameter = new SqlParameter("@NewPassword", SqlDbType.VarChar, 50);
                    passwordParameter.Value = value;
                    command.Parameters.Add(passwordParameter);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            string query = $"UPDATE customer SET {attribute} = '{value}' WHERE {ID} = CustID";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Get_cust_history(int id)
        {
            //barber name ,service name ,price,comment ,rating,appointment time ,status
            string query = "SELECT CONCAT(employee.first_name,' ',employee.last_name)AS BarberName,appointment.status,appointment.appointmentTime,custcomment,rating,service.service_name FROM appointment INNER JOIN service ON serviceID=service_id  INNER JOIN employee ON barberid=EMP_id WHERE customerID = " + id + "AND status=finished;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable getservices()
        {
            string query = "SELECT Service_id,service_name FROM service";
            return (DataTable)dbMan.ExecuteReader(query);
        }
        public int getprice(string id) {
           
            string query = "SELECT price FROM service WHERE service_id = " + Int32.Parse(id)+ ";";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int add_appointment(int custid, int serviceid, int paymentid, string time) {
            string query = "INSERT INTO appointment (customerID, serviceID, paymentID, barberID, appointmentTime, status) VALUES " +
               "('" + custid + "', '" + serviceid + "', '" + paymentid + "', NULL, '" + time + "', 'Pending');";

            //string query= "INSERT INTO appointment (customerID,serviceID,paymentID,barberID,appointmentTime,status) VALUES " +
            //  " ('" + custid + "','" + serviceid + "','" + paymentid + ", NULL ," + time  + "','" + "Pending" + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int addpayment(string method,int amount)
        {
            string query = "INSERT INTO Payment_Transaction (type,payment_method,status,amount) VALUES " +
              " ('" + "incoming"+"','"+ method +"','"+"Pending"+"','"+amount+ "');  SELECT SCOPE_IDENTITY();";
                return Int32.Parse(dbMan.ExecuteScalar(query).ToString());
        }
    }
}
