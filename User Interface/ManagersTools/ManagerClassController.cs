using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop_Operations_Platform.User_Interface.ManagersTools
{
    internal class ManagerClassController
    {
        DBManager dbMan;
        public ManagerClassController()
        {
            dbMan = new DBManager();
        }

        public DataTable GetBarbers()
        {
            string Query = "Select E.Emp_id, CONCAT(E.First_name, ' ', E.Last_name) AS Name, A.date AS Date FROM Employee AS E, Barber AS B, Attendance_Log AS A WHERE B.Emp_id = E.Emp_id AND A.emp_id = E.Emp_id ;";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable GetBarberHistory(int BID)
        {
            string Query = "SELECT CONCAT(E.First_name, ' ' ,E.Last_name) AS BName, S.service_name AS Service, A.Rating AS Rating" +
                " FROM Appointment AS A, Employee AS E, Service As S " +
                $"WHERE A.BarberID = {BID} AND A.BarberID = E.Emp_id AND A.ServiceID = S.service_id;";
            return dbMan.ExecuteReader(Query);

        }




        public DataTable GetCustomers()
        {
            string Query = "Select E.Emp_id, CONCAT(E.First_name, ' ', E.Last_name) AS Name FROM Employee AS E, Barber AS B WHERE B.Emp_id = E.Emp_id ;";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable GetCustomersHistory(int BID)
        {
            string Query = "SELECT CONCAT(E.First_name, ' ' ,E.Last_name) AS BName, S.service_name AS Service, A.Rating AS Rating" +
                " FROM Appointment AS A, Employee AS E, Service As S " +
                $"WHERE A.BarberID = {BID} AND A.BarberID = E.Emp_id AND A.ServiceID = S.service_id;";
            return dbMan.ExecuteReader(Query);

        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
