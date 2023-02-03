using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Domain;
using TelcoSystemCore.Infrastructure;

namespace TelcoSystemCore.Common
{
    public class DAOFactory
    {
        public static ICustomerDAO CreateCustomerDAO()
        {
            ICustomerDAO customerDAO = new CustomerSqlDAOImpl();
            return (ICustomerDAO)customerDAO;
        }

        public static IReceiptDetailsDAO CreateReceiptDetailsDAO()
        {
            IReceiptDetailsDAO receiptDetailsDAO = new ReceiptDetailsSqlDAOImpl();
            return (IReceiptDetailsDAO)receiptDetailsDAO;
        }

        public static IAccountBillingDAO CreateAccountBillingDAO()
        {
            IAccountBillingDAO accountBillingDAO = new AccountBillingSqlDAOImpl();
            return (IAccountBillingDAO)accountBillingDAO;
        }

        public static IPaymentTypeDAO CreatePaymentTypeDAO()
        {
            IPaymentTypeDAO paymentTypeDAO = new PaymentTypeSqlDAOImpl();
            return (IPaymentTypeDAO)paymentTypeDAO;
        }

        public static IChequeDetailDAO CreateChequeDetailDAO()
        {
            IChequeDetailDAO chequeDetailDAO = new ChequeDetailSqlDAOImpl();
            return (IChequeDetailDAO)chequeDetailDAO;
        }

        public static ILteLoginDAO CreateLteLoginDAO()
        {
            ILteLoginDAO lteLoginDAO = new LteloginPgSqlDAOImpl();
            return (ILteLoginDAO)lteLoginDAO;
        }

        public static IBankBillPaymentsDAO CreateBankBillPaymentsDAO()
        {
            IBankBillPaymentsDAO bankBillPaymentsDAO = new BankBillPaymentsDAOPgSqlImpl();
            return (IBankBillPaymentsDAO)bankBillPaymentsDAO;
        }



        //cmLogComplain
        public static ICmLogComplainsDAO CreateCmLogComplainsDAO()
        {
            ICmLogComplainsDAO CmLogComplainsDAO = new CmLogComplainsSqlDAOImpl();
            return (ICmLogComplainsDAO)CmLogComplainsDAO;
        }

        //CustomerAccount


        //Additional data pack request
        public static IAdditionalDataPackRequestDAO CreateAdditionalDataPackRequestDAO()
        {
            IAdditionalDataPackRequestDAO additionalDataPackRequestDAO = new AdditionalDataPackRequestSqlDAOImpl();
            return (IAdditionalDataPackRequestDAO)additionalDataPackRequestDAO;
        }

        //account location
        public static IAccountLocationDAO CreateAccountLocationDAO()
        {
            IAccountLocationDAO accountLocationDAO = new AccountLocationSqlDAOImpl();
            return (IAccountLocationDAO)accountLocationDAO;
        }

        //location profile
        public static ILocationProfileDAO CreateLocationProfileDAO()
        {
            ILocationProfileDAO locationProfileDAO = new LocationProfileSqlDAOImpl();
            return (ILocationProfileDAO)locationProfileDAO;
        }

        //cm category type master
        public static ICmCategoryTypeMasterDAO CreateCmCategoryTypeMasterDAO()
        {
            ICmCategoryTypeMasterDAO cmCategoryTypeMasterDAO = new CmCategoryTypeMasterSqlDAOImpl();
            return (ICmCategoryTypeMasterDAO)cmCategoryTypeMasterDAO;
        }

        //cm complain type master
        public static ICmComplainTypeMasterDAO CreateCmComplainTypeMasterDAO()
        {
            ICmComplainTypeMasterDAO cmComplainTypeMasterDAO = new CmComplainTypeMasterSqlDAOImpl();
            return (ICmComplainTypeMasterDAO)cmComplainTypeMasterDAO;
        }

        //cm complain sub type master
        public static ICmComplainSubTypeMasterDAO CreateCmComplainSubTypeMasterDAO()
        {
            ICmComplainSubTypeMasterDAO cmComplainSubTypeMasterDAO = new CmComplainSubTypeMasterSqlDAOImpl();
            return (ICmComplainSubTypeMasterDAO)cmComplainSubTypeMasterDAO;
        }

        // cm log complain save data
        //public static ICmLogComplainsDAO CreateCmLogComplainsDAO()
        //{
        //    ICmLogComplainsDAO cmLogComplainDAO = new CmLogComplainsSqlDAOImpl();
        //    return (ICmLogComplainsDAO)cmLogComplainDAO;
        //}
        public static IBillSettlementDAO CreateBillSettlementDAO()
        {
            IBillSettlementDAO billSettlementDAO = new BillSettlementSqlDAOImpl();
            return (IBillSettlementDAO)billSettlementDAO;
        }
        //com sections master
        public static IComSectionsMastersDAO CreateComSectionsMastersDAO()
        {
            IComSectionsMastersDAO comSectionsMastersDAO = new ComSectionsMastersSqlDAOImpl();
            return (IComSectionsMastersDAO)comSectionsMastersDAO;
        }

        public static IComplainRemarksDAO CreateComplainRemarksDAO()
        {
            IComplainRemarksDAO complainRemarksDAO = new ComplainRemarksSqlDAOImpl();
            return (IComplainRemarksDAO)complainRemarksDAO;
        }

        //pnbs menu users
        public static IPnbsMenuRolesUsersDAO CreatePnbsMenuRolesUsersDAO()
        {
            IPnbsMenuRolesUsersDAO pnbsMenuRolesUsersDAO = new PnbsMenuRolesUsersSqlDAOImpl();
            return (IPnbsMenuRolesUsersDAO)pnbsMenuRolesUsersDAO;
        }


        public static IPaymentModeDAO CreatePaymentModeDAO()
        {
            IPaymentModeDAO paymentModeDAO = new PaymentModeSqlDAOImpl();
            return (IPaymentModeDAO)paymentModeDAO;
        }

     

        public static ICusAccountDNDAO CreateCusAccountDNDAO()
        {
            ICusAccountDNDAO cusAccountDNDAO = new CusAccountDNSqlDAOImpl();
            return (ICusAccountDNDAO)cusAccountDNDAO;
        }

        public static IReceiptUploadDAO CreateReceiptUploadDAO()
        {
            IReceiptUploadDAO receiptUploadDAO = new ReceiptUploadSqlDAOImpl();
            return (IReceiptUploadDAO)receiptUploadDAO;

        }

        public static IDocumentCategoryDAO CreateDocumentCategoryDAO()
        {
            IDocumentCategoryDAO documentCategoryDAO = new DocumentCategorySqlDAOImpl();
            return (IDocumentCategoryDAO)documentCategoryDAO;
        }




    }
}
