using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TelcoSystemCore.Controller;
using TelcoSystemCore.Common;
using TelcoSystemCore.Domain;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;


namespace TelcoSystem
{

    public partial class Complain : System.Web.UI.Page
    {
        List<Customer> listCustomer = new List<Customer>();
        List<CustomerAccount> listCustomerAccount = new List<CustomerAccount>();
        List<AccountLocation> listAccountLocation = new List<AccountLocation>();
        List<BillSettlement> listBillSettlement = new List<BillSettlement>();

        public string ddlNearestBo;
        public string ddlCategoryType;
        public string ddlCom;
        public string ddlComSub;
        //public string ddlSectionMaster;
        public string seqId;
        public string bound;
        public string followStatus;
        string pnbs_id;
        private static int lastId = 0;
        private static DateTime lastDate;
        

        //ICustomerController customerController = ControllerFactory.CreateCustomerDetailController();
        //Customer customer = new Customer();



        protected void Page_Load(object sender, EventArgs e)
        {
     

            if(!IsPostBack)
            {
                pnbs_id = Server.UrlDecode(Request.QueryString["id"]);

               

                //txtLoggedName.InnerText = pnbs_id;
                //txtSubLoggedName.InnerText = pnbs_id;
                //string shortDate = DateTime.Now.ToShortDateString();
                string shortDate = DateTime.Now.ToString("yyyy-MM-dd");
                DateTime currentDate = DateTime.Parse(shortDate);
                
                //DateTime currentDate = DateTime.Now.Date;
                logged_date.Text = currentDate.ToString();

                //get sequence number
                seqId = GenerateSequenceId();
                ref_no.Text = seqId.ToString();

                BindSections();
                BindNearestBO();
                BindCategory();
                BindComplain();
                BindComplainSubCategory();
                //dvInfo.Visible = false;
            }
            

        }

        //generate sequence number
        string GenerateSequenceId()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }


        protected void customerDetails_TextChanged(object sender, EventArgs e)
        {
            if (service_number.Text != "")
            {
                var test = service_number.Text;
                var phone = test.ToString();
                ICustomerController customerController = ControllerFactory.CreateCustomerDetailController();
                listCustomer = customerController.GetCustomerDetailList(phone);
                //listCustomer = customerController.GetCustomerDetailList(service_number.Text);
                ICustomerAccountController customerAccountController = ControllerFactory.CreateCustomerAccountDetailController();
                listCustomerAccount = customerAccountController.GetCustomerAccountDetailList(phone);
                //account location
                IAccountLocationController accountLocationController = ControllerFactory.CreateAccountLocationDetailController();
                listAccountLocation = accountLocationController.GetAccountLocationDetailList(phone);
                //bill settlement
                IBillSettlementController billSettlementController = ControllerFactory.CreateBillSettlementController();
                listBillSettlement = billSettlementController.GetBillSettlementDetailList(phone);


                if (listCustomer[0].CustomerId != "" || listCustomer[0].CustomerId != null)
                {
                    
                    //customer
                    customer_name.Text = listCustomer[0].CustomerName;
                    customer_id.Text = listCustomer[0].CustomerId;

                    //customerAccount
                   
                    acc_code.Text = listCustomerAccount[0].accountId;

                    var ad1 = listCustomerAccount[0].addressLine1;
                    var ad2 = listCustomerAccount[0].addressLine2;
                    var ad3 = listCustomerAccount[0].addressLine3;

                    var address = ad1 + ", " + ad2 + ", " + ad3;

                    account_address.Text = address;

                    city.Text = listCustomerAccount[0].city;

                    //additional data pack request
                    user_code.Text = listAccountLocation[0].AccountLocationId;
                    //bill settlement
                    bill_balance.Text = listBillSettlement[0].Amount;
                }
            }

        }

       
        protected void Save_btn(object sender, EventArgs e)
        {
            CmLogComplains complains = new CmLogComplains();
            ComplainRemarks compRe = new ComplainRemarks();

            complains.CompId = ref_no.Text;

            string currentDateString = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime currentDate = DateTime.Parse(currentDateString);

            complains.TxnDate = currentDate;

            complains.CustName = customer_name.Text;
            complains.CompCatCode = ddlCategory.SelectedValue;
            complains.CompType = ddlComplain.SelectedValue;
            complains.CompSubType = ddlComplainSub.SelectedValue;

            complains.InfoTo = ddlSectionMaster.SelectedValue;

            var test_serviceNum = service_number.Text;
            complains.DnSvcNo = test_serviceNum.ToString();

            complains.LoginName = pnbs_id;
            complains.AccCode = acc_code.Text;
            complains.AccRating = acc_rating.Text;
            complains.ConnStatus = connection_status.Text;
            complains.AccCategory = account_category.Text;
            complains.LineType = "ab1";
            complains.LineUsage = line_usage.Text;
  
            complains.LastMonthBill = 89;
            complains.UserCode = user_code.Text;
            complains.Address = account_address.Text;
            complains.City = city.Text;
            complains.CustRemarks = concern.Text;
            complains.ContactPerson = contact_person.Text;
            complains.InformedBy = "Imal";
            complains.ContactNo = contact_number.Text;
            complains.Followup = rbFollow.SelectedValue;

            string check = "0";
            if(complains.Followup != check)
            {
                complains.Followup = "Y";
                complains.Status = "P";
                //dvInfo.Visible = true;
            }
            else
            {
                complains.Followup = "N";
                complains.Status = "D";
                //dvInfo.Visible = false;
            }
            //complains.Status = "ab3";
            complains.ItBstr = "cd";
            complains.LoggedBy = "imal";
            //complains.LoggedOn = ;
            complains.ModifiedBy = "kovindaJ";
            //complains.ModifiedOn = ;
            //complains.AttendedOn = ;
            //complains.CompletedOn = ;
            complains.RefCompId = ref_no.Text;
            complains.UrgentComp = "k";
            complains.SystemType = "sm";
            complains.Email = email.Text;
            complains.Directed = "a";
            
            complains.CompletedBy = "AB14";
            //complains.HoldTo = "12-MAR-2023";
            complains.CallType = "l";
            complains.FaultId = 2;
            complains.CompSectionId = "ab50";
            complains.Rejected = "r";
            complains.Note = "null";


            //enter in form but no in table.....
            //complains.CustomerId = customer_id.Text;

            //complains.BillBalance = bill_balance.Text;
            //complains.CreditLimit = credit_limit.Text;
            //complains.nearestBo = ddlNearestBo;
            //complains.Fid = fid.Text;

            //remark data

            //get sequence number
            seqId = GenerateSequenceId();

            
           
            //compRe.RemarkId = "1";
            //compRe.SeqId ="3";
            compRe.CompId = ref_no.Text;
            compRe.SectionId = ddlSectionMaster.SelectedValue;
            compRe.ReInfoDate = currentDate;
            compRe.MyRemarks = "init_comp";
            compRe.UserCode = pnbs_id;





            ICmLogComplainsController cmLogComplainsController = ControllerFactory.CreateCmLogComplainsDAO();
            cmLogComplainsController.Save(complains);

            //sent to remarks table
            IComplainRemarksController complainRemarksController = ControllerFactory.CreateComplainRemarksDetailController();
            complainRemarksController.Save(compRe);

            ClearMe();
        }
        private void ClearMe()
        {
            service_number.Text = string.Empty;
            user_code.Text = string.Empty;
            acc_code.Text = string.Empty;
            customer_id.Text = string.Empty;
            customer_name.Text = string.Empty;
            customer_id.Text = string.Empty;
            account_address.Text = string.Empty;
            city.Text = string.Empty;

            connection_status.Text = string.Empty;
            acc_rating.Text = string.Empty;
            line_usage.Text = string.Empty;
            //infoTo.Text = string.Empty;
            account_category.Text = string.Empty;
            bill_run_date.Text = string.Empty;
            bill_balance.Text = string.Empty;
            credit_limit.Text = string.Empty;
            concern.Text = string.Empty;
            contact_person.Text = string.Empty;
            contact_number.Text = string.Empty;
            email.Text = string.Empty;
            informed_by.Text = string.Empty;
            fid.Text = string.Empty;






        }
       


        //public void ddl_nearestBo(object sender, EventArgs e)
        //{
        //    ddlNearestBo = ddlNearestBd.SelectedValue.ToString();

        //}
        //public void ddl_category(object sender, EventArgs e)
        //{
        //    ddlCategoryType = ddlCategory.SelectedValue.ToString();

        //}
        //public void ddl_complain(object sender, EventArgs e)
        //{
        //    ddlCom = ddlComplain.SelectedValue.ToString();

        //}
        //public void ddl_complainSub(object sender, EventArgs e)
        //{
        //    ddlComSub = ddlComplainSub.SelectedValue.ToString();

        //}

        private void BindNearestBO()
        {
            ILocationProfileController locationProfileController = ControllerFactory.CreateLocationProfileDetailController();
            List<LocationProfile> locationProf = locationProfileController.GetLocationProfileDetailList();

            ddlNearestBd.DataSource = locationProf;
            ddlNearestBd.DataValueField = "LocatCd";
            ddlNearestBd.DataTextField = "LocatName";

            ddlNearestBd.DataBind();

        }

        public void BindCategory()
        {
            ICmCategoryTypeMasterController cmCategoryTypeMasterController = ControllerFactory.CreateCmCategoryTypeMasterDetailController();
            List<CmCategoryTypeMaster> locationProf = cmCategoryTypeMasterController.GetCmCategoryTypeMasterDetailList();

            ddlCategory.DataSource = locationProf;
            ddlCategory.DataValueField = "Code";
            ddlCategory.DataTextField = "Description";

            ddlCategory.DataBind();
        }

        public void BindComplain()
        {
            ICmComplainTypeMasterController cmComplainTypeMasterController = ControllerFactory.CreateCmComplainTypeMasterDetailController();
            List<CmComplainTypeMaster> locationProf = cmComplainTypeMasterController.GetCmComplainTypeMasterDetailList();

            ddlComplain.DataSource = locationProf;
            ddlComplain.DataValueField = "Code";
            ddlComplain.DataTextField = "Description";

            ddlComplain.DataBind();
        }

        public void BindComplainSubCategory()
        {
            ICmComplainSubTypeMasterController cmComplainSubTypeMasterController = ControllerFactory.CreateCmComplainSubTypeMasterDetailController();
            List<CmComplainSubTypeMaster> locationProf = cmComplainSubTypeMasterController.GetCmComplainSubTypeMasterDetailList();

            ddlComplainSub.DataSource = locationProf;
            ddlComplainSub.DataValueField = "Code";
            ddlComplainSub.DataTextField = "Description";

            ddlComplainSub.DataBind();
        }

        private void BindSections()
        {
            IComSectionsMastersController comSectionsMastersController = ControllerFactory.CreateComSectionsMastersDetailController();
            List<ComSectionsMasters> comSectionsMasters = comSectionsMastersController.GetComSectionsMastersDetailList();

            ddlSectionMaster.DataSource = comSectionsMasters;
            ddlSectionMaster.DataValueField = "SectionId";
            ddlSectionMaster.DataTextField = "SectionName";

            ddlSectionMaster.DataBind();

        }

        protected void GoToDashboard(object sender, EventArgs e)
        {
            //Server.Transfer("ComplainDashboard.aspx");
        }

      
    }
}