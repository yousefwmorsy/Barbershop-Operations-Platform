using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop_Operations_Platform
{
    internal class BarberController
    {
        DBManager dbMan;

        public BarberController()
        {
            dbMan = new DBManager();
        }

        public DataTable GetPersonalInfo(int barberid)
        {
            //string query = $"Select e.Emp_id, e.First_Name, e.Last_name, e.Phone_number, e.Address, e.Email, b.Start_time, " +
            //    $"b.End_Time, Concat(manager.First_Name,' ', manager.Last_name) AS Manager_Name " +
            //    $"From Employee e, Barber b, Employee manager" +
            //    $"Where e.Emp_id = b.Emp_id AND e.Emp_id = {barberid} AND manager.Emp_id = e.manager_id;";

            string query = $"Select e.Emp_id, e.First_Name, e.Last_name, e.Phone_number, e.Address, e.Email, b.Start_time, " +
                $"b.End_Time, Concat(manager.First_Name,' ', manager.Last_name) AS Manager_Name " +
                $"From Employee e " +
                $"Join Barber b ON e.Emp_id = b.Emp_id " +
                $"Join Employee manager ON manager.Emp_id = e.manager_id " +
                $"Where e.Emp_id = {barberid};";

            return dbMan.ExecuteReader(query);
        }
        
        public int UpdateStartOrEndTime(string timeType,  string time, int barberID)
        {
            string query = $"UPDATE Employee " +
                $"SET {timeType} = {time} " +
                $"WHERE Emp_id = {barberID};";

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

        public DataTable GetAvailableSupplies()
        {
            string query = $"SELECT supplyID, supply_Name, Quantity\r\nFROM Inventory\r\nORDER BY Quantity;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSupplyRequests(int barberid)
        {
            string query = $"SELECT supply_Name, sr.date, sr.quantity, CONCAT(e.First_name, ' ', e.Last_name) AS Manager_Name, sr.manager_id, sr.status " +
                $"FROM Supply_Request sr, Inventory, Employee e " +
                $"WHERE supplyID = supply_id AND sr.manager_id = e.Emp_id AND barber_id = {barberid};";
            return dbMan.ExecuteReader(query);
        }

        public int InsertSupplyRequest(int barberid, int supply_id, int quantity)
        {
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            string status = "Pending";
            int managerid = GetManagerID(barberid);
            string query = $"Insert Into Supply_Request(barber_id, supply_id, date, quantity, manager_id, status) " +
                $"Values({barberid}, {supply_id}, '{date}', {quantity}, {managerid}, '{status}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateSupplyRequest(int barberid, int supply_id, int quantity)
        {
            string date = DateTime.Today.ToString("yyyy-MM-dd");

            string updateQuery = $"UPDATE Supply_Request " +
                $"SET quantity = {quantity} " +
                $"WHERE barber_id = {barberid} AND supply_id = {supply_id} AND date = '{date}' AND status = 'Pending';";
            return dbMan.ExecuteNonQuery(updateQuery);
        }
        public int CheckSupplyRequestExistance(int barberid, int supply_id)
        {
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            string checkQuery = $"SELECT COUNT(*) " +
                $"FROM Supply_Request " +
                $"WHERE barber_id = {barberid} AND supply_id = {supply_id} AND date = '{date}' AND status = 'Pending';";
            return (int)dbMan.ExecuteScalar(checkQuery);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
