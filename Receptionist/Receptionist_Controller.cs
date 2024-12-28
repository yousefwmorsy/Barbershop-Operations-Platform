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

        public DataTable ViewTodayUnassignedAppointments()
        {
            string query = $"SELECT AppointmentID as ID, service_name as 'Service', CONVERT(VARCHAR(16), AppointmentTime, 120) AS Time\r\n FROM [dbo].[Appointment] as a, [dbo].[Service] WHERE  a.BarberID IS NULL AND a.ServiceID = Service.service_id AND AppointmentTime >= '{DateTime.Now.ToString("yyyy-MM-dd")} 00:00:00' AND AppointmentTime <= '{DateTime.Now.ToString("yyyy-MM-dd")} 23:59:59'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewAvailableBarbers()
        {
            string query = $"SELECT  e.Emp_id as BarberID, CONCAT(e.First_name, ' ', e.Last_name) as 'Barber', b.start_time as 'Start Time', b.end_time as 'End Time'\r\nFROM [dbo].[Employee] as e, [dbo].[ManagedEmployees] as m, [dbo].[Barber] as b\r\nWHERE e.Emp_id = m.EmpId AND b.Emp_id = e.Emp_id AND m.OnDayOff = 'False'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewOfflinePayments()
        {
            string query = $"SELECT a.PaymentID, AppointmentID, CONCAT(c.FName, ' ',c.LName) as 'Customer', amount as 'Amount' , AppointmentTime\r\nFROM [dbo].[Payment_Transaction] as p, [dbo].[Appointment] as a, [dbo].[ReceptionistPayment] as r, [dbo].[Customer] as c\r\nWHERE p.payment_id = a.PaymentID AND r.PaymentID = p.payment_id AND p.status = 'Pending' AND c.CustID = a.CustomerID AND p.Type = 'Appointment' and p.payment_method = 'Offline'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewAllAppointments()
        {
            string query = $"SELECT \r\n    CASE \r\n        WHEN a.CustomerID = 12 THEN pa.CustName\r\n        ELSE CONCAT(c.FName, ' ', c.LName)\r\n    END AS 'Customer',\r\n    s.service_name AS 'Service',\r\n    CONVERT(VARCHAR(16), a.AppointmentTime, 120) AS 'Time',\r\n    a.Status\r\nFROM \r\n    [dbo].[Appointment] AS a\r\nLEFT JOIN \r\n    [dbo].[Customer] AS c ON a.CustomerID = c.CustID\r\nLEFT JOIN \r\n    [dbo].[Service] AS s ON a.ServiceID = s.service_id\r\nLEFT JOIN \r\n    [dbo].[PhoneAppointment] AS pa ON a.AppointmentID = pa.AppID\r\nWHERE \r\n    a.AppointmentTime >= '{DateTime.Now.ToString("yyyy-MM-dd") + " " + "00:00:00"}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewAllAppointmentsID()
        {
            string query = $"SELECT \r\n    a.AppointmentID as ID, CASE \r\n        WHEN a.CustomerID = 12 THEN pa.CustName\r\n        ELSE CONCAT(c.FName, ' ', c.LName)\r\n    END AS 'Customer',\r\n    s.service_name AS 'Service',\r\n    CONVERT(VARCHAR(16), a.AppointmentTime, 120) AS 'Time',\r\n    a.Status\r\nFROM \r\n    [dbo].[Appointment] AS a\r\nLEFT JOIN \r\n    [dbo].[Customer] AS c ON a.CustomerID = c.CustID\r\nLEFT JOIN \r\n    [dbo].[Service] AS s ON a.ServiceID = s.service_id\r\nLEFT JOIN \r\n    [dbo].[PhoneAppointment] AS pa ON a.AppointmentID = pa.AppID\r\nWHERE \r\n    a.AppointmentTime >= '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' AND a.Status != 'Done'";
            return dbMan.ExecuteReader(query);
        }

        public DateTime GetAppTime(int appid)
        {
            string query = $"SELECT AppointmentTime FROM Appointment WHERE AppointmentID = {appid}";
            return (DateTime)dbMan.ExecuteScalar(query);
        }

        public int CheckBarberFree(int empid, int appid)
        {
            string time = GetAppTime(appid).ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"SELECT Count(*) FROM Appointment WHERE BarberID = {empid} AND AppointmentTime = '{time}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public TimeSpan GetBarberStart(int empid)
        {
            string query = $"SELECT Start_Time FROM Barber WHERE Emp_id = {empid}";
            return (TimeSpan)dbMan.ExecuteScalar(query);
        }

        public TimeSpan GetBarberEnd(int empid)
        {
            string query = $"SELECT End_Time FROM Barber WHERE Emp_id = {empid}";
            return (TimeSpan)dbMan.ExecuteScalar(query);
        }

        public int AssignBarber(int empid, int appid)
        {
            string query = $"UPDATE Appointment SET BarberID = {empid}, Status = 'Assigned' WHERE AppointmentID = {appid}";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetServices()
        {
            string query = $"SELECT service_id, Service_Name From Service";
            return dbMan.ExecuteReader(query);
        }
        public int GetServicePrice(int serviceid)
        {
            string query = $"SELECT Price from Service where service_id = {serviceid}";
            return (int)dbMan.ExecuteScalar(query);
        }
        
        public int AddOfflinePayment(int serviceid)
        {
            int price = GetServicePrice(serviceid);
            string query = $"INSERT INTO Payment_Transaction(Type, payment_method, Status, Amount) VALUES('Appointment', 'Cash', 'Pending', {price})";
            return dbMan.ExecuteNonQuery(query);
        }

        public int GetScopeIdentity()
        {
            string query = $"SELECT SCOPE_IDENTITY() As ID";
            return Convert.ToInt32((decimal)dbMan.ExecuteScalar(query));
        }

        public int AddOfflineAppointment(string name, string apptime, int serviceid, int empid)
        {
            AddOfflinePayment(serviceid);
            int paymentid = GetScopeIdentity();
            string query = $"INSERT INTO Appointment(CustomerID, ServiceID, BarberID, PaymentID, AppointmentTime) VALUES (12, {serviceid}, NULL, {paymentid}, '{apptime}')";
            int q1 = dbMan.ExecuteNonQuery(query);
            string query2 = $"INSERT INTO PhoneAppointment(EmpID, AppID, CustName) VALUES ({empid}, {GetScopeIdentity()}, '{name}')";
            return q1+dbMan.ExecuteNonQuery(query2);
        }

        public int MarkDone(int appid)
        {
            string query = $"UPDATE Appointment SET Status = 'Done' WHERE AppointmentID = {appid}";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Delete(int appid)
        {
            string query = $"DELETE FROM Appointment WHERE AppointmentID = {appid}";
            return dbMan.ExecuteNonQuery(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
