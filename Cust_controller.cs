using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
    }
}

