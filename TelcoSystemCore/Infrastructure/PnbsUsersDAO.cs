using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IPnbsUsersDAO
    {
        //bool GetPnbsUsers(string username, string password, DbConnection dbConnection);
        int GetPnbsUsers(DbConnection dbConnection, PnbsUsers pnbsUsers);
    }

    public class PnbsUsersSqlDAOImpl : IPnbsUsersDAO

    {


        public int GetPnbsUsers(DbConnection dbConnection, PnbsUsers pnbsUsers)
        {
            //"DILEEKAS"
            //"C3E4119CCF6628BA"

            //"LOCHANAW"
            //"2F19F7E5EFEA182EA78FC26F6BCAC7DB"

            int output = 0;

            dbConnection.cmd.Parameters.Clear();
            dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            dbConnection.cmd.CommandText = "SELECT * FROM lb.pnbs_users WHERE pnbs_id = '" + pnbsUsers.PnbsId + "' AND password = '" + pnbsUsers.Password + "'";

            //dbConnection.cmd.Parameters.AddWithValue("@PnbsId", pnbsUsers.PnbsId);
            //dbConnection.cmd.Parameters.AddWithValue("@Password", pnbsUsers.Password);

            output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());

            return output;


        }

    }
}
