using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop_Operations_Platform
{
    internal class LoginController
    {
        DBManager dbMan;
        public LoginController()
        {
            dbMan = new DBManager();
        }

        public int GetSignedUser(string username, string password)
        {
            int i = 0; string Query = ""; // 0-> Customer, 1-> Barber, 2-> Receptionist, 3-> Manager, 4-> SuperManager, -1-> Not Found 
            Query = $"SELECT FName FROM Customer Where Email = '{username}' AND Password = '{password}';" ;
            if (dbMan.ExecuteScalar(Query) != null)
            {
                return i;
            }

            string[] TableName = {"Barber", "Receptionist", "Manager"};
            foreach (string TN in TableName)
            {
                i++;
                Query = $"SELECT A.Emp_id FROM Employee AS A, {TN} AS B WHERE A.Emp_id = B.Emp_id AND A.Email = '{username}' AND A.Password = '{password}';";
                if (dbMan.ExecuteScalar(Query) != null)
                {
                    if ((int)dbMan.ExecuteScalar(Query) == 1)
                    {
                        return ++i;    
                    }
                    return i;
                }
            }
            return -1; 
        }
        
        public int GetEmployeeID(string email)
        {
            string Query = $"SELECT Emp_id FROM Employee WHERE Email = '{email}';";
            return (int)dbMan.ExecuteScalar(Query);
        }

        public int GetUserID(string email)
        {
            string query = $"SELECT CustID FROM Customer WHERE Email = '{email}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
