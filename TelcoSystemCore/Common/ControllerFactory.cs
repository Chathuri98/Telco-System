using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Controller;

namespace TelcoSystemCore.Common
{
    public class ControllerFactory
    {
        public static ILteLoginController CreateLteLoginController()
        {
            ILteLoginController lteLoginController = new LteLoginControllerPgSqlImpl();
            return (ILteLoginController)lteLoginController;
        }
        public static ICustomerController CreateCustomerDetailController()
        {
            ICustomerController customerDetailController = new CustomerControllerImpl();
            return (ICustomerController)customerDetailController;
        }

        public static IChequeDetailController CreateChequeDetailController()
        {
            IChequeDetailController chequeDetailController = new ChequeDetailControllerImpl();
            return (IChequeDetailController)chequeDetailController;
        }

        public static IBankBillPaymentController CreateBankBillPaymentController()
        {
            IBankBillPaymentController bankBillPaymentController = new BankBillPaymentControllerPgSqlImpl();
            return (IBankBillPaymentController)bankBillPaymentController;
        }


        //cmLogComplains
        public static ICmLogComplainsController CreateCmLogComplainsDAO()
        {
            ICmLogComplainsController cmLogComplainsController = new CmLogComplainsControllerImpl();
            return (ICmLogComplainsController)cmLogComplainsController;
        }

        //CustomerAccount


        //Additional data pack request
        public static IAdditionalDataPackRequestController CreateAdditionalDataPackRequestDetailController()
        {
            IAdditionalDataPackRequestController additionalDataPackRequestDetailController = new AdditionalDataPackRequestControllerImpl();
            return (IAdditionalDataPackRequestController)additionalDataPackRequestDetailController;
        }

        //account location
        public static IAccountLocationController CreateAccountLocationDetailController()
        {
            IAccountLocationController accountLocationDetailController = new AccountLocationControllerImpl();
            return (IAccountLocationController)accountLocationDetailController;
        }

        //location profile
        public static ILocationProfileController CreateLocationProfileDetailController()
        {
            ILocationProfileController locationProfileDetailController = new LocationProfileControllerImpl();
            return (ILocationProfileController)locationProfileDetailController;
        }

        public static ICmCategoryTypeMasterController CreateCmCategoryTypeMasterDetailController()
        {
            ICmCategoryTypeMasterController cmCategoryTypeMasterDetailController = new CmCategoryTypeMasterControllerImpl();
            return (ICmCategoryTypeMasterController)cmCategoryTypeMasterDetailController;
        }

        //cm complain type master
        public static ICmComplainTypeMasterController CreateCmComplainTypeMasterDetailController()
        {
            ICmComplainTypeMasterController cmComplainTypeMasterDetailController = new CmComplainTypeMasterControllerImpl();
            return (ICmComplainTypeMasterController)cmComplainTypeMasterDetailController;
        }

        //cm complain sub type master
        public static ICmComplainSubTypeMasterController CreateCmComplainSubTypeMasterDetailController()
        {
            ICmComplainSubTypeMasterController cmComplainSubTypeMasterDetailController = new CmComplainSubTypeMasterControllerImpl();
            return (ICmComplainSubTypeMasterController)cmComplainSubTypeMasterDetailController;
        }

        //cm log complains data save
        public static ICmLogComplainsController CreateCmLogComplainsController()
        {
            ICmLogComplainsController cmLogComplainsController = new CmLogComplainsControllerImpl();
            return (ICmLogComplainsController)cmLogComplainsController;
        }
        //insert into lb.customer_account values ('502185','JAY SEA FOODS PROCESSING PVT LTD','N(PVS)14323','BA','LB',null,'REC','01','CPG','M/S','27','SOYSA WATTE','DUNGALPITIYA','NEGOMBO','00000','MALIKAN','09-AUG-00','BILLRUN','16-MAR-14',28,null,null,'DL','B',0,'30011','28',null,'NALINP','T02','WESTERN','GAMPAHA',0,'COR','COR',null,'N','N','30-JAN-17',null,'BSMB',null,null,'N','C',3000,null,null,null,'805061','N/R',null,'N',null,null,'BUS' )
        public static IBillSettlementController CreateBillSettlementController()
        {
            IBillSettlementController billSettlementController = new BillSettlementControllerImpl();
            return (IBillSettlementController)billSettlementController;
        }

        //com sections masters
        public static IComSectionsMastersController CreateComSectionsMastersDetailController()
        {
            IComSectionsMastersController comSectionsMastersDetailController = new ComSectionsMastersControllerImpl();
            return (IComSectionsMastersController)comSectionsMastersDetailController;
        }

        // ComplainRemarks
        public static IComplainRemarksController CreateComplainRemarksDetailController()
        {
            IComplainRemarksController complainRemarksDetailController = new ComplainRemarksControllerImpl();
            return (IComplainRemarksController)complainRemarksDetailController;
        }

        //pnbs menu users
        public static IPnbsMenuRolesUsersController CreatePnbsMenuRolesUsersDetailController()
        {
            IPnbsMenuRolesUsersController pnbsMenuRolesUsersDetailController = new PnbsMenuRolesUsersControllerImpl();
            return (IPnbsMenuRolesUsersController)pnbsMenuRolesUsersDetailController;
        }


        public static IAccountBillingController CreateAccountBillingController()
        {
            IAccountBillingController accountBillingController = new AccountBillingControllerImpl();
            return (IAccountBillingController)accountBillingController;
        }

        public static IReceiptDetailsController CreateReceiptDetailsController()
        {
            IReceiptDetailsController receiptDetailsController = new ReceiptDetailsControllerImpl();
            return (IReceiptDetailsController)receiptDetailsController;
        }



        public static IPaymentTypeController CreatePaymentTypeController()
        {
            IPaymentTypeController paymentTypeController = new PaymentTypeControllerImpl();
            return (IPaymentTypeController)paymentTypeController;
        }



        public static IPaymentModeController CreatePaymentModeController()
        {
            IPaymentModeController paymentModeController = new PaymentModeControllerImpl();
            return (IPaymentModeController)paymentModeController;
        }



        public static ICusAccountDNController CreateCusAccountDNController()
        {
            ICusAccountDNController cusAccountDNController = new CusAccountDNControllerImpl();
            return (ICusAccountDNController)cusAccountDNController;
        }

        public static IReceiptUploadController CreateReceiptUploadController()
        {
            IReceiptUploadController receiptUploadController = new ReceiptUploadControllerImpl();
            return (IReceiptUploadController)receiptUploadController;
        }


        public static IDocumentCategoryController CretaeDocumentCategoryController()
        {
            IDocumentCategoryController documentCategoryController = new DocumentCategoryCpntrollerImpl();
            return (IDocumentCategoryController)documentCategoryController;
        }

    }
}
