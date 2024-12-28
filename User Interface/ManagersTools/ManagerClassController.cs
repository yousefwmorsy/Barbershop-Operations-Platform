﻿using System;
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
            string Query = "SELECT C.CustID, CONCAT(C.FName, ' ', C.LName) AS Name, C.Phone_Number AS Phone_Number " +
                "FROM Customer AS C";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable GetCustomersHistory(int CID)
        {
            string Query = "SELECT CONCAT(C.FName, ' ' ,C.FName) AS BName , S.service_name AS Service_Name," +
                " P.Payment_method AS Payment_Method, P.Amount AS Amount" +
                " FROM Customer AS C, Appointment AS A, Payment_Transaction AS P, Service AS S " +
                $" WHERE C.CustID = {CID} AND A.CustomerID = C.CustID AND A.ServiceID = S.service_id AND A.PaymentID = P.payment_id;";
            return dbMan.ExecuteReader(Query);

        }





        public DataTable GetServices()
        {
            string Query = "SELECT * FROM Service;";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable GetOffers()
        {
            string Query = "Select S.service_name AS Service_Name, O.Start_date AS Start_Date, O.End_date AS END_Date " +
                "FROM Service AS S, Offers AS O " +
                "WHERE O.Service_id = S.service_id;";
            return dbMan.ExecuteReader(Query);
        }

        public int AddOffer(int SID, string SDate, string EDate)
        {
            string Query = $"INSERT INTO Offers VALUES({SID}, '{SDate}', '{EDate}');";
            return dbMan.ExecuteNonQuery(Query);
        }



        public DataTable GetFeedBacks()
        {
            string Query = "SELECT CONCAT(C.FName, ' ', C.LName) AS Customer_Name, CONCAT(E.First_name, ' ', E.Last_name) AS Barber_Name" +
                ", A.AppointmentTime As Time, A.CustComment AS Customer_Comment, A.Rating AS Rating " +
                "FROM Appointment AS A, Barber AS B, Employee AS E, Customer AS C " +
                $"WHERE A.CustomerID = C.CustID AND A.BarberID = B.Emp_id AND B.Emp_id = E.Emp_id AND Status = 'Done';";
            return dbMan.ExecuteReader(Query);
        }

        public DataTable GetIncidentReport()
        {
            string Query = "SELECT CONCAT(E.First_name, ' ', E.Last_name) AS Barber_Name, CONCAT(C.FName, ' ', C.LName) AS Customer_Name" +
                ", A.AppointmentTime As Time, A.IncidentReport AS Incident_Report " +
                "FROM Appointment AS A, Barber AS B, Employee AS E, Customer AS C " +
                $"WHERE A.CustomerID = C.CustID AND A.BarberID = B.Emp_id AND B.Emp_id = E.Emp_id AND Status = 'Done';";
            return dbMan.ExecuteReader(Query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
