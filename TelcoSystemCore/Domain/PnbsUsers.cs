using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable()]
    public class PnbsUsers
    {

        [DBField("EMP_ID")]
        public int EmpId { get; set; }


        [DBField("NAME")]
        public string Name { get; set; }


        [DBField("PNBS_ID")]
        public string PnbsId { get; set; }

        [DBField("NW_USERID")]
        public int NwUserid { get; set; }


        [DBField("LOCATION")]
        public string Location { get; set; }


        [DBField("NIC_ID ")]
        public string NicId { get; set; }

        [DBField("DEPARTMENT")]
        public string Department { get; set; }


        [DBField("DIVISION")]
        public string Division { get; set; }


        [DBField("CREATED_ON")]
        public int CreatedOn { get; set; }

        [DBField("CREATED_BY")]
        public int CreatedBy { get; set; }


        [DBField("DEACTIVATED_ON")]
        public int DeactivatedOn { get; set; }


        [DBField("DEACTIVATED_BY")]
        public int DeactivatedBy { get; set; }

        [DBField("CONTACT_NO")]
        public int ContactNo { get; set; }


        [DBField("PASSWORD")]
        public string Password { get; set; }


        [DBField("FIRST_LOGIN ")]
        public int FirstLogin { get; set; }

        [DBField("CURRENT_LOGIN")]
        public int CurrentLogin { get; set; }


        [DBField("PREVIOUS_LOGIN")]
        public int PreviousLogin { get; set; }



    }


}
