using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop_Operations_Platform
{
    public class Receptionist_Controller
    {
        DBManager dbMan;

        public Receptionist_Controller(DBManager x)
        {
           dbMan = x;
        }

        public DataTable GetPersonalInfo(int id)
        {
            string query = $"SELECT CONCAT(First_Name, ' ', Last_Name) AS \"Name\", Phone_number, Address, Email, OnDayOff\nFROM [dbo].[Employee], [dbo].[ManagedEmployees]\nWHERE Emp_id = EmpID AND Emp_id = {id}";
            return dbMan.ExecuteReader(query);
        }
        
        public int UpdatePhone(int id, string number)
        {
            string query = $"UPDATE Employee SET Phone_number = '{number}' WHERE Emp_id = {id}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEmail(int id, string email)
        {
            string query = $"UPDATE Employee SET Email = '{email}' WHERE Emp_id = {id}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateAddress(int id, string address)
        {
            string query = $"UPDATE Employee SET Address = '{address}' WHERE Emp_id = {id}";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetBarberSchedule(int barberid)
        {
            string query = $"Select a.AppointmentID, a.CustomerID, a.CustComment, a.AppointmentTime " +
                $"From Appointment a " +
                $"Where a.Status != 'Finished' AND a.BarberID = {barberid}";
            return dbMan.ExecuteReader(query);
        }

        public int GetManagerID(int empid)
        {
            string query = $"SELECT Manager_id " +
                $"FROM Employee " +
                $"Where Emp_id = {empid};";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int InsertDayOffRequest(int empid, string sdate, string edate)
        {
            int managerid = GetManagerID(empid);
            string status = "Pending";
            //string query = 
            //return dbMan.ExecuteNonQuery(query);
            return 0;
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
