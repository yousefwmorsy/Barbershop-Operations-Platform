using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop_Operations_Platform.User_Interface.ManageEmployees
{
    internal class DaysOffController
    {
        DBManager dbMan;
        public DaysOffController()
        {
            dbMan = new DBManager();
        }

        public DataTable ViewDaysOff()
        {
            string Query = "Select * From DaysOffRequest";
            return dbMan.ExecuteReader(Query);
        }
        
        public int DeclineRequest(int id)
        {
            string Query = $"UPDATE DaysOffRequest SET Status = 'Declined' WHERE RequestID = {id};";
            return dbMan.ExecuteNonQuery(Query);
        }

        public int AcceptRequest(int Rid, int Eid)
        {
            string Query = $"UPDATE DaysOffRequest SET Status = 'Accepted' WHERE RequestID = {Rid}; " +
                $"Update ManagedEmployees SET OnDayOff = 'True' WHERE EmpID = {Eid};";
            return dbMan.ExecuteNonQuery(Query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
