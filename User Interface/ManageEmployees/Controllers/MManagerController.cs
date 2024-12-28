using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop_Operations_Platform.User_Interface.ManageEmployees
{
    internal class MManagerController
    {
        DBManager dbMan;
        public MManagerController()
        {
            dbMan = new DBManager();
        }

        public DataTable ViewManagers()
        {
            string Query = "SELECT E.Emp_id, E.First_name, E.Last_name " +
                "FROM Employee AS E, Manager AS M WHERE E.Emp_id = M.Emp_id AND E.Emp_id!=1;";
            return dbMan.ExecuteReader(Query);
        }

        public int GetMaxID()
        {
            string Query = "SELECT MAX(Emp_id) From Employee";
            return (int)dbMan.ExecuteScalar(Query);
        }

        public int InsertManager(string FN, string LN, int MID, string PhNum, string Address, string Email, string Password)
        {
            string Query = "INSERT INTO Employee (First_name, Last_name, Manager_id, Phone_number, Address, Email, Password) " +
                " VALUES ( '" + FN + "', '" + LN + "', " + MID + ", '" + PhNum + "', '" + Address + "', '" + Email + "', '" + Password + "') ;";
            dbMan.ExecuteNonQuery(Query);
            int ID = GetMaxID();
            Query = "INSERT INTO Manager (Emp_id) VALUES ( " + ID + " );";
            return dbMan.ExecuteNonQuery(Query);
        }

        public int Delete(int id)
        {
            string Query = "DELETE FROM Manager WHERE Emp_id = " + id + ";" +
                "DELETE FROM Employee WHERE Emp_id = " + id + ";";
            return dbMan.ExecuteNonQuery(Query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
