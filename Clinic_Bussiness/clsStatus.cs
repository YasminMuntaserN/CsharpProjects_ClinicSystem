using Clinic_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Bussiness
{
    public class clsStatus
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }

        public clsStatus()
        {
            this.StatusID = -1;
            this.StatusName = "";
        }

        public clsStatus(int statusID, string statusName)
        {
            this.StatusID = statusID;
            this.StatusName = statusName;
        }

        public static clsStatus Find(int StatusID)
        {
            string StatusName = "";
            bool IsFound = clsStatusData.GetStatusInfoByID(StatusID, ref StatusName);
            if (IsFound)
            {
                return new clsStatus(StatusID, StatusName);
            }
            return null;
        }

        public static clsStatus Find(string statusName)
        {
            int StatusID = -1;
            bool IsFound = clsStatusData.GetStatusInfoByName(statusName, ref StatusID);
            if (IsFound)
            {
                return new clsStatus(StatusID, statusName);
            }
            return null;
        }

        public static string getStatusName(int StatusID)
        {
            clsStatus status = Find(StatusID);
            return (status == null) ? "" : status.StatusName;

        }

    }
}
