using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop_Operations_Platform.User_Interface.ManageEmployees.Controllers
{
    internal class SuppReqController
    {
        DBManager dbMan;
        public SuppReqController()
        {
            dbMan = new DBManager();
        }

        public DataTable ViewRequests(int MID)
        {
            string Query = $"SELECT S.barber_id, CONCAT(E.First_name, ' ' ,E.Last_name) AS BName,  S.supply_id, I.supply_Name AS SupplyName ,S.date AS Date," +
                $" S.quantity AS Quantity, S.status AS Status FROM Supply_Request AS S, Employee AS E, Inventory AS I" +
                $" WHERE S.manager_id = {MID} AND E.Emp_id = S.barber_id AND S.supply_id = I.supplyID;";
            return dbMan.ExecuteReader(Query);
        }

        public int GetSuppPrice(int id)
        {
            string Query = $"SELECT Price From Inventory WHERE supplyID = {id}";
            return (int)dbMan.ExecuteScalar(Query);
        }

        public int GetLastPaymentID()
        {
            string Query = "SELECT MAX(payment_id) From Payment_Transaction";
            return (int)dbMan.ExecuteScalar(Query);
        }

        public int AcceptRequest(int BID, int SID , DateTime Date, int SQ)
        {
            string Query = $"UPDATE Supply_Request SET status = 'Accepted' Where barber_id = {BID} AND supply_id = {SID} AND date = '{Date.ToString("yyyy-MM-dd")}';" + 
                $"INSERT INTO Payment_Transaction (type, payment_method, status, amount) " +
                $"VALUES ('Supply', 'Offline', 'Paid', {GetSuppPrice(SID)*SQ});";
            dbMan.ExecuteScalar(Query);
            Query = $"INSERT INTO SuppliesBought VALUES ({GetLastPaymentID()}, {SID}, {SQ});" +
                $"UPDATE Inventory SET Quantity += {SQ} WHERE supplyID = {SID};";
            return dbMan.ExecuteNonQuery(Query);
        }

        public int DeclineRequest(int PID)
        {
            string Query = "";
            return dbMan.ExecuteNonQuery(Query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
