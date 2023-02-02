﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using DbConnection = TelcoSystemCore.Common.DbConnection;

namespace TelcoSystemCore.Infrastructure
{
    public interface IAccountLocationDAO
    {
        int Save(AccountLocation accountLocation, DbConnection dbConnection);
        int Update(AccountLocation accountLocation, DbConnection dbConnection);
        List<AccountLocation> GetAccountLocationDetailList(DbConnection dbConnection, string phoneNumber);
    }

    public class AccountLocationSqlDAOImpl : IAccountLocationDAO
    {
        public List<AccountLocation> GetAccountLocationDetailList(DbConnection dbConnection, string phoneNumber)
        {
            List<AccountLocation> accountLocationDetailList = new List<AccountLocation>();
            dbConnection = new DbConnection();


            dbConnection.cmd.CommandText =
                "SELECT * FROM lb.account_location INNER JOIN lb.customer_account_dn ON customer_account_dn.account_id = account_location.account_id WHERE customer_account_dn.account_dn = ?";



            dbConnection.cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            dbConnection.dr = dbConnection.cmd.ExecuteReader();

            DataAccessObject dataAccessObject = new DataAccessObject();

            accountLocationDetailList = dataAccessObject.ReadCollection<AccountLocation>(dbConnection.dr);
            dbConnection.dr.Close();

            return accountLocationDetailList;

     
        }

        public int Save(AccountLocation accountLocation, DbConnection dbConnection)
        {
            throw new NotImplementedException();

            //int output = 0;

            //dbConnection.cmd.Parameters.Clear();
            //dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            //dbConnection.cmd.CommandText = "Insert into Customer (CUSTOMER_ID, CUSTOMER_NAME, CUSTOMER_TYPE_ID, TITLE,ACTIVATED_ON, ACTIVATED_BY, ADDRESS_LINE_1, ADDRESS_LINE_2, ADDRESS_LINE_3, CITY, POSTAL_CODE, MODIFIED_BY, MODIFIED_ON, PROFILE_STATUS, CP_REMARKS, DISTRICT, PROVINCE, CUST_GROUP, CUST_RATING, TOP_CUSTOMER_STAT, CONFIDENTIAL, PREFERRED_LANGUAGE, PROFESSION_DESIGNATION, DATE_OF_BIRTH, CONTACT_PHONE_NO, MANAGER_1, MANAGER_2, SALES_PERSON, NEW_ID_NUMBER) " +
            //                                      "values (@CUSTOMER_ID,@CUSTOMER_NAME,@CUSTOMER_TYPE_ID,@TITLE,@ACTIVATED_ON,@ACTIVATED_BY,@ADDRESS_LINE_1, @ADDRESS_LINE_2, @ADDRESS_LINE_3, @CITY, @POSTAL_CODE, @MODIFIED_BY, @MODIFIED_ON, @PROFILE_STATUS, @CP_REMARKS, @DISTRICT, @PROVINCE, @CUST_GROUP, @CUST_RATING, @TOP_CUSTOMER_STAT, @CONFIDENTIAL, @PREFERRED_LANGUAGE, @PROFESSION_DESIGNATION, @DATE_OF_BIRTH, @CONTACT_PHONE_NO, @MANAGER_1, @MANAGER_2, @SALES_PERSON, @NEW_ID_NUMBER) SELECT SCOPE_IDENTITY() ";


            //dbConnection.cmd.Parameters.AddWithValue("@CUSTOMER_ID", customer.CustomerId);
            //dbConnection.cmd.Parameters.AddWithValue("@CUSTOMER_NAME", customer.CustomerName);
            //dbConnection.cmd.Parameters.AddWithValue("@CUSTOMER_TYPE_ID", customer.CustomerTypeId);
            //dbConnection.cmd.Parameters.AddWithValue("@TITLE", customer.Title);
            //dbConnection.cmd.Parameters.AddWithValue("@ACTIVATED_ON", customer.ActivatedOn);
            //dbConnection.cmd.Parameters.AddWithValue("@ACTIVATED_BY", customer.ActivatedBy);
            //dbConnection.cmd.Parameters.AddWithValue("@ADDRESS_LINE_1", customer.AddressLine1);
            //dbConnection.cmd.Parameters.AddWithValue("@ADDRESS_LINE_2", customer.AddressLine2);
            //dbConnection.cmd.Parameters.AddWithValue("@ADDRESS_LINE_3", customer.AddressLine3);
            //dbConnection.cmd.Parameters.AddWithValue("@CITY", customer.City);
            //dbConnection.cmd.Parameters.AddWithValue("@POSTAL_CODE", customer.PostalCode);
            //dbConnection.cmd.Parameters.AddWithValue("@MODIFIED_BY", customer.ModifiedBy);
            //dbConnection.cmd.Parameters.AddWithValue("@MODIFIED_ON", customer.ModifiedOn);
            //dbConnection.cmd.Parameters.AddWithValue("@PROFILE_STATUS", customer.ProfileStatus);
            //dbConnection.cmd.Parameters.AddWithValue("@CP_REMARKS", customer.CpRemarks);
            //dbConnection.cmd.Parameters.AddWithValue("@DISTRICT", customer.District);
            //dbConnection.cmd.Parameters.AddWithValue("@PROVINCE", customer.Province);
            //dbConnection.cmd.Parameters.AddWithValue("@CUST_GROUP", customer.CustGroup);
            //dbConnection.cmd.Parameters.AddWithValue("@CUST_RATING", customer.CustRating);
            //dbConnection.cmd.Parameters.AddWithValue("@TOP_CUSTOMER_STAT", customer.TopCustomerStat);
            //dbConnection.cmd.Parameters.AddWithValue("@CONFIDENTIAL", customer.Confidential);
            //dbConnection.cmd.Parameters.AddWithValue("@PREFERRED_LANGUAGE", customer.PreferredLanguage);
            //dbConnection.cmd.Parameters.AddWithValue("@PROFESSION_DESIGNATION", customer.ProfessionDesignation);
            //dbConnection.cmd.Parameters.AddWithValue("@DATE_OF_BIRTH", customer.DateOfBirth);
            //dbConnection.cmd.Parameters.AddWithValue("@CONTACT_PHONE_NO", customer.ContactPhoneNumber);
            //dbConnection.cmd.Parameters.AddWithValue("@MANAGER_1", customer.Manager1);
            //dbConnection.cmd.Parameters.AddWithValue("@MANAGER_2", customer.Manager2);
            //dbConnection.cmd.Parameters.AddWithValue("@SALES_PERSON", customer.SalesPerson);
            //dbConnection.cmd.Parameters.AddWithValue("@NEW_ID_NUMBER", customer.NewIdNumber);


            //output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            //return output;


        }

        public int Update(AccountLocation accountLocation, DbConnection dbConnection)
        {
            throw new NotImplementedException();

            //int output = 0;

            //dbConnection.cmd.Parameters.Clear();
            //dbConnection.cmd.CommandType = System.Data.CommandType.Text;
            //dbConnection.cmd.CommandText = "Update Student set CUSTOMER_ID = @CUSTOMER_ID ,CUSTOMER_NAME = @CUSTOMER_NAME,CUSTOMER_TYPE_ID = @CUSTOMER_TYPE_ID,TITLE  =@TITLE ,ACTIVATED_ON = @ACTIVATED_ON, ACTIVATED_BY = @ACTIVATED_BY, ADDRESS_LINE_1= @ADDRESS_LINE_1, ADDRESS_LINE_2 = @ADDRESS_LINE_2, ADDRESS_LINE_3 = @ADDRESS_LINE_3, CITY = @CITY, POSTAL_CODE = @POSTAL_CODE,  MODIFIED_BY = @MODIFIED_BY, MODIFIED_ON = @MODIFIED_ON, PROFILE_STATUS = @PROFILE_STATUS, CP_REMARKS = @CP_REMARKS, DISTRICT = @DISTRICT, PROVINCE = @PROVINCE, CUST_GROUP = @CUST_GROUP, CUST_RATING = @CUST_RATING, TOP_CUSTOMER_STAT = @TOP_CUSTOMER_STAT, CONFIDENTIAL = @CONFIDENTIAL, PREFERRED_LANGUAGE = @PREFERRED_LANGUAGE, PROFESSION_DESIGNATION = @PROFESSION_DESIGNATION, DATE_OF_BIRTH = @DATE_OF_BIRTH, CONTACT_PHONE_NO = @CONTACT_PHONE_NO, MANAGER_1 = @MANAGER_1, MANAGER_2 = @MANAGER_2, SALES_PERSON = @SALES_PERSON, NEW_ID_NUMBER = @NEW_ID_NUMBER WHERE CUSTOMER_ID = @CUSTOMER_ID ";

            //dbConnection.cmd.Parameters.AddWithValue("@CUSTOMER_ID", customer.CustomerId);
            //dbConnection.cmd.Parameters.AddWithValue("@CUSTOMER_NAME", customer.CustomerName);
            //dbConnection.cmd.Parameters.AddWithValue("@CUSTOMER_TYPE_ID", customer.CustomerTypeId);
            //dbConnection.cmd.Parameters.AddWithValue("@TITLE", customer.Title);
            //dbConnection.cmd.Parameters.AddWithValue("@ACTIVATED_ON", customer.ActivatedOn);
            //dbConnection.cmd.Parameters.AddWithValue("@ACTIVATED_BY", customer.ActivatedBy);
            //dbConnection.cmd.Parameters.AddWithValue("@ADDRESS_LINE_1", customer.AddressLine1);
            //dbConnection.cmd.Parameters.AddWithValue("@ADDRESS_LINE_2", customer.AddressLine2);
            //dbConnection.cmd.Parameters.AddWithValue("@ADDRESS_LINE_3", customer.AddressLine3);
            //dbConnection.cmd.Parameters.AddWithValue("@CITY", customer.City);
            //dbConnection.cmd.Parameters.AddWithValue("@POSTAL_CODE", customer.PostalCode);
            //dbConnection.cmd.Parameters.AddWithValue("@MODIFIED_BY", customer.ModifiedBy);
            //dbConnection.cmd.Parameters.AddWithValue("@MODIFIED_ON", customer.ModifiedOn);
            //dbConnection.cmd.Parameters.AddWithValue("@PROFILE_STATUS", customer.ProfileStatus);
            //dbConnection.cmd.Parameters.AddWithValue("@CP_REMARKS", customer.CpRemarks);
            //dbConnection.cmd.Parameters.AddWithValue("@DISTRICT", customer.District);
            //dbConnection.cmd.Parameters.AddWithValue("@PROVINCE", customer.Province);
            //dbConnection.cmd.Parameters.AddWithValue("@CUST_GROUP", customer.CustGroup);
            //dbConnection.cmd.Parameters.AddWithValue("@CUST_RATING", customer.CustRating);
            //dbConnection.cmd.Parameters.AddWithValue("@TOP_CUSTOMER_STAT", customer.TopCustomerStat);
            //dbConnection.cmd.Parameters.AddWithValue("@CONFIDENTIAL", customer.Confidential);
            //dbConnection.cmd.Parameters.AddWithValue("@PREFERRED_LANGUAGE", customer.PreferredLanguage);
            //dbConnection.cmd.Parameters.AddWithValue("@PROFESSION_DESIGNATION", customer.ProfessionDesignation);
            //dbConnection.cmd.Parameters.AddWithValue("@DATE_OF_BIRTH", customer.DateOfBirth);
            //dbConnection.cmd.Parameters.AddWithValue("@CONTACT_PHONE_NO", customer.ContactPhoneNumber);
            //dbConnection.cmd.Parameters.AddWithValue("@MANAGER_1", customer.Manager1);
            //dbConnection.cmd.Parameters.AddWithValue("@MANAGER_2", customer.Manager2);
            //dbConnection.cmd.Parameters.AddWithValue("@SALES_PERSON", customer.SalesPerson);
            //dbConnection.cmd.Parameters.AddWithValue("@NEW_ID_NUMBER", customer.NewIdNumber);

            //output = Convert.ToInt32(dbConnection.cmd.ExecuteScalar());


            //return output;
        }
    }
}
