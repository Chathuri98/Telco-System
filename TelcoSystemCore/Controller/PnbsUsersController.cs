using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Infrastructure;


namespace TelcoSystemCore.Controller
{
    public interface IPnbsUsersController
    {
        //bool GetPnbsUsers(string username, string password);

        int GetPnbsUsers(PnbsUsers pnbsUsers);
    }

    public class PnbsUsersControllerSqlImpl : IPnbsUsersController
    {
        IPnbsUsersDAO PnbsUsersDAO = DAOFactory.CreateGetPnbsUsersDAO();

        //public bool GetPnbsUsers(string username, string password)
        //{
        //    DbConnection dbConnection = null;
        //    PnbsUsers PnbsUsers = new PnbsUsers();
        //    bool PnbsUsersStatus;

        //    try
        //    {
        //        dbConnection = new DbConnection();
        //        PnbsUsersStatus = PnbsUsersDAO.GetPnbsUsers(username,password, dbConnection);

        //    }
        //    catch (Exception)
        //    {
        //        dbConnection.RollBack();
        //        throw;
        //    }
        //    finally
        //    {
        //        if (dbConnection.con.State == System.Data.ConnectionState.Open)
        //        {
        //            dbConnection.Commit();
        //        }
        //    }
        //    return PnbsUsersStatus;
        //}


        public int GetPnbsUsers(PnbsUsers pnbsUsers)
        {
            DbConnection dbConnection = null;
            //PnbsUsers PnbsUsers = new PnbsUsers();

            try
            {
                dbConnection = new DbConnection();
                return PnbsUsersDAO.GetPnbsUsers(dbConnection, pnbsUsers);

            }
            catch (Exception)
            {
                //HttpContext.Current.Response.Redirect("500.aspx");
                dbConnection.RollBack();
                throw;
            }
            finally
            {
                if (dbConnection.con.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Commit();
                }
            }
        }
    }
}
