﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop_Operations_Platform.User_Interface.ManageEmployees
{
    internal class MBarberController
    {
        DBManager dbMan;
        public MBarberController()
        {
            dbMan = new DBManager();
        }

        public DataTable ViewBarbers()
        {
            string Query = "SELECT E.Emp_id, E.First_name, E.Last_name " +
                "FROM Employee AS E, Barber AS B WHERE E.Emp_id = B.Emp_id;";
            return dbMan.ExecuteReader(Query);
        }

        public int GetMaxID()
        {
            string Query = "SELECT MAX(Emp_id) From Employee";
            return (int)dbMan.ExecuteScalar(Query);
        }

        public int InsertBarber(string FN, string LN, int MID, string PhNum, string Address, string Email, string Password, string ST, string ET)
        {
            string Query = "INSERT INTO Employee (First_name, Last_name, Manager_id, Phone_number, Address, Email, Password) " +
                " VALUES ( '" + FN + "', '" + LN + "', " + MID + ", '" + PhNum + "', '" + Address + "', '" + Email + "', '" + Password + "') ;";
            dbMan.ExecuteNonQuery(Query);
            int ID = GetMaxID();
            Query = "INSERT INTO ManagedEmployees VALUES ( " + ID + ", 'False' ); " +
                "INSERT INTO Barber VALUES ( " + ID + ", '" + ST + "', '" + ET + "' );";
            return dbMan.ExecuteNonQuery(Query);
        }

        public int Delete(int id)
        {
            string Query = "DELETE FROM Barber WHERE Emp_id = " + id + ";" +
                "DELETE FROM ManagedEmployees WHERE EmpID = " + id + ";" +
                "DELETE FROM Employee WHERE Emp_id = " + id + ";";
            return dbMan.ExecuteNonQuery(Query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}