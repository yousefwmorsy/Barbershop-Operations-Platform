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

        public int InsertDayOffRequest(int empid, string startdate, string enddate)
        {
            int managerid = GetManagerID(empid);
            string query = $"INSERT INTO DaysOffRequest (EmployeeID, ManagerID, StartDate, EndDate) VALUES ({empid}, {managerid}, '{startdate}', '{enddate}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public int CheckRepeatedRequests(int empid, string startdate, string enddate) {
            string query = $"SELECT Count(*) FROM DaysOffRequest WHERE StartDate = '{startdate}' AND EndDate = '{enddate}' AND EmployeeID = {empid}";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable ViewPrevRequests(int id)
        {
            string query = $"SELECT CONCAT(m.First_Name, ' ', m.Last_Name) as 'Manager Name', StartDate, EndDate, Status \r\nFROM Employee as m, DaysOffRequest\r\nWHERE m.Emp_id = ManagerID AND EmployeeID = {id} AND EndDate >= '{DateTime.Now.ToString("yyyy-MM-dd")}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewTodayAppointments()
        {
            string query = $"SELECT AppointmentID, CONCAT(c.FName, ' ', c.LName) as 'Customer', CONCAT(b.First_name, ' ', Last_name) as 'Barber', service_name as 'Service', AppointmentTime\r\nFROM [dbo].[Appointment] as a, [dbo].[Customer] as c, [dbo].[Employee] as b, [dbo].[Service]\r\nWHERE a.CustomerID = c.CustID AND a.BarberID = b.Emp_id AND a.ServiceID = Service.service_id AND AppointmentTime >= '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewAvailableBarbers()
        {
            string query = $"SELECT CONCAT(e.First_name, ' ', e.Last_name) as 'Barber', b.start_time as 'Start Time', b.end_time as 'End Time'\r\nFROM [dbo].[Employee] as e, [dbo].[ManagedEmployees] as m, [dbo].[Barber] as b\r\nWHERE e.Emp_id = m.EmpId AND b.Emp_id = e.Emp_id AND m.OnDayOff = 'False'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewOfflinePayments()
        {
            string query = $"SELECT a.PaymentID, AppointmentID, CONCAT(c.FName, ' ',c.LName) as 'Customer', amount as 'Amount' , AppointmentTime\r\nFROM [dbo].[Payment_Transaction] as p, [dbo].[Appointment] as a, [dbo].[ReceptionistPayment] as r, [dbo].[Customer] as c\r\nWHERE p.payment_id = a.PaymentID AND r.PaymentID = p.payment_id AND p.status = 'Pending' AND c.CustID = a.CustomerID AND p.Type = 'Appointment' and p.payment_method = 'Offline'";
            return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
