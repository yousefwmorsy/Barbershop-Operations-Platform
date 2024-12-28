using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
            string query = $"Select e.Emp_id, e.First_Name, e.Last_name, e.Phone_number, e.Address, e.Email, b.Start_time, " +
                $"b.End_Time, Concat(manager.First_Name,' ', manager.Last_name) AS Manager_Name " +
                $"From Employee e " +
                $"Join Barber b ON e.Emp_id = b.Emp_id " +
                $"Join Employee manager ON manager.Emp_id = e.manager_id " +
                $"Where e.Emp_id = {barberid};";

            return dbMan.ExecuteReader(query);
        }
        
        public int UpdatePersonalInfo(string toUpdateField, string updatedValue, int empid)
        {
            string query = $"Update Employee " +
                $"Set {toUpdateField} = '{updatedValue}' " +
                $"Where Emp_id = {empid};";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetBarberSchedule(int barberid)
        {
            string query = $"Select a.AppointmentID, a.CustomerID, CONCAT(c.FName, ' ', c.LName) AS Name, a.CustComment, a.AppointmentTime, status " +
                $"From Appointment a " +
                $"JOIN Customer c ON a.CustomerID = c.CustID " +
                $"Where a.Status != 'Finished' AND a.BarberID = {barberid} " +
                $"ORDER BY DAY(AppointmentTime) DESC, DATEPART(HOUR, AppointmentTime) ASC;";
            return dbMan.ExecuteReader(query);
        }

        public int GetManagerID(int empid)
        {
            string query = $"SELECT Manager_id " +
                $"FROM Employee " +
                $"Where Emp_id = {empid};";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable GetAvailableSupplies()
        {
            string query = $"SELECT supplyID, supply_Name, Quantity\r\nFROM Inventory\r\nORDER BY Quantity;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSupplyRequests(int barberid)
        {
            string query = $"SELECT supply_Name,  sr.status, sr.date, sr.quantity, CONCAT(e.First_name, ' ', e.Last_name) AS Manager_Name " +
                $"FROM Supply_Request sr, Inventory, Employee e " +
                $"WHERE supplyID = supply_id AND sr.manager_id = e.Emp_id AND barber_id = {barberid} " +
                $"ORDER BY sr.date DESC;";
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

        public int CheckDaysOffEligiblitiy(string startDate, string endDate, int empID)
        {
            string query = $"Select Count(*) " +
                $"From DaysOffRequest d " +
                $"Where EmployeeID = {empID} AND " +
                $"((StartDate <= '{startDate}' AND EndDate >= '{startDate}') OR (StartDate <= '{endDate}' AND EndDate >= '{endDate}'));";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable GetDaysOffClashes(string startDate, string endDate, int empID)
        {
            string query = $"Select StartDate, EndDate, Status " +
                $"From DaysOffRequest d " +
                $"Where EmployeeID = {empID} AND " +
                $"((StartDate <= '{startDate}' AND EndDate >= '{startDate}') OR (StartDate <= '{endDate}' AND EndDate >= '{endDate}'));";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetDaysOffRequests(int barberid)
        {
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            string query = $"Select StartDate, EndDate, Status " +
            $"From DaysOffRequest d " +
            $"Where EmployeeID = {barberid} AND EndDate >= '{date} " +
            $"ORDER BY EndDate ASC';";
            return dbMan.ExecuteReader(query);
        }
        public int InsertDaysOffRequest(int empid, string startDate, string endDate)
        {
            string status = "Pending";
            int managerid = GetManagerID(empid);
            string query = $"Insert Into DaysOffRequest(EmployeeID, ManagerID, StartDate, EndDate, Status) " +
                    $"Values ({empid}, {managerid}, '{startDate}', '{endDate}', '{status}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetAttendanceLog(int empId)
        {
            string query = $"SELECT date " +
                $"From Attendance_Log " +
                $"Where emp_id = {empId} " +
                $"ORDER BY date DESC;";
            return dbMan.ExecuteReader(query);
        }
        public int InsertAttendance(int barberid)
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");
            string query = $"Insert Into Attendance_Log(emp_id, date) " +
                $"Values ({barberid}, '{today}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetAppointmentsWithoutIncidents(int barberid)
        {
            string query = $"SELECT a.AppointmentID AS 'Appointment Number', CONCAT(c.FName, ' ', c.LName) AS 'Customer Name', s.service_name AS 'Service Name', a.AppointmentTime AS 'Time', a.IncidentReport As 'Incident Report' " +
                $"FROM Appointment a " +
                $"JOIN Customer c ON a.CustomerID = c.CustID " +
                $"JOIN Service s ON s.service_id = a.AppointmentID " +
                $"WHERE BarberID = {barberid} AND a.Status = 'Done';";
            return dbMan.ExecuteReader(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
