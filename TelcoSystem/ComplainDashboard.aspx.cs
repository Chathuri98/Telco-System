using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Web.UI.WebControls;
using TelcoSystemCore.Common;
using TelcoSystemCore.Controller;
using TelcoSystemCore.Domain;

namespace TelcoSystem
{
    public partial class ComplainDashboard : System.Web.UI.Page
    {
        List<CmLogComplains> listCmLogComplains = new List<CmLogComplains>();
        List<ComplainRemarks> complainRemarks = new List<ComplainRemarks>();
        //CmLogComplains objDone = new CmLogComplains();
        string ComplainSort;
        //string complainData;
        string pnbs_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnbs_id = Server.UrlDecode(Request.QueryString["id"]);

                //txtLoggedName.InnerText = pnbs_id;
                //txtSubLoggedName.InnerText = pnbs_id;

                BindSections();
                BindDataSource();
                dvView_More.Visible = false;
                dvCompRemarks_grid.Visible = false;
                popup.Visible = false;
                //confirmBox.Visible = false;

            }
            //if (Session["user_id"] == null)
            //{
            //    Response.Redirect("Login.aspx");
            //}
            //else
            //{
            //    if (Session["User_Role_Id"].ToString() == "1" || Session["User_Role_Id"].ToString() == "2")
            //    {
            //        BindDataSource();
            //    }
            //    else
            //    {
            //        Response.Redirect("404.aspx");
            //    }
            //}

        }
        
        //load data rows
        protected void BindDataSource()
        {
            var userId = pnbs_id;//"LBIVR";
            ICmLogComplainsController cmLogComplainsController = ControllerFactory.CreateCmLogComplainsDAO();
            listCmLogComplains = cmLogComplainsController.GetCmLogComplainsList(userId);
           
            GridView.DataSource = listCmLogComplains;
            GridView.DataBind();

        }
        protected void btnRemarks_Click(object sender, EventArgs e)
        {
            dvCompRemarks_grid.Visible = true;

            LinkButton button = (LinkButton)sender;
            string compId = button.CommandArgument;

            IComplainRemarksController complainRemarksController = ControllerFactory.CreateComplainRemarksDetailController();
            complainRemarks = complainRemarksController.GetComplainRemarksDetailList(compId);

            GridViewRemarks.DataSource = complainRemarks;
            GridViewRemarks.DataBind();
        }

        //make complain btn
        protected void makeComplain(object sender, EventArgs e)
        {
            var transId = pnbs_id;
            Session["pnbs_id"] = transId;
            Response.Redirect("Complain.aspx?id=" + Session["pnbs_id"]);
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            //Server.Transfer("ViewComplains.aspx");
            dvView_More.Visible = true;

            LinkButton button = (LinkButton)sender;
            string compid = button.CommandArgument;
            ComplainSort = compid;
            ICmLogComplainsController cmLogComplainsController = ControllerFactory.CreateCmLogComplainsDAO();
            listCmLogComplains = cmLogComplainsController.ViewMoreCmLogComplains(compid);

            comp_id.Text = listCmLogComplains[0].CompId;
            
            cust_name.Text = listCmLogComplains[0].CustName;
            comp_cat_code.Text = listCmLogComplains[0].CompCatCode;
            comp_type.Text = listCmLogComplains[0].CompType;
            comp_sub_type.Text = listCmLogComplains[0].CompSubType;
            dn_svc_no.Text = listCmLogComplains[0].DnSvcNo;
            acc_code.Text = listCmLogComplains[0].AccCode;
            acc_rating.Text = listCmLogComplains[0].AccRating;
            conn_status.Text = listCmLogComplains[0].ConnStatus;
            acc_category.Text = listCmLogComplains[0].AccCategory;
            line_type.Text = listCmLogComplains[0].LineType;
            line_usage.Text = listCmLogComplains[0].LineUsage;
            last_month_bill.Text = listCmLogComplains[0].LastMonthBill.ToString();
            user_code.Text = listCmLogComplains[0].UserCode;
            comp_address.Text = listCmLogComplains[0].Address;

            cust_remarks.Text = listCmLogComplains[0].CustRemarks;
            contact_person.Text = listCmLogComplains[0].ContactPerson;
            contact_no.Text = listCmLogComplains[0].ContactNo;
            informed_by.Text = listCmLogComplains[0].InformedBy;
            logged_by.Text = listCmLogComplains[0].LoggedBy;
            attended_on.Text = listCmLogComplains[0].AttendedOn.ToString();
            //info_to.Text = listCmLogComplains[0].InfoTo;
            ref_comp_id.Text = listCmLogComplains[0].RefCompId;
            urgent_comp.Text = listCmLogComplains[0].UrgentComp;
            hold_to.Text = listCmLogComplains[0].HoldTo.ToString();
            fault_id.Text = listCmLogComplains[0].FaultId.ToString();
            rejected.Text = listCmLogComplains[0].Rejected;
            txn_date.Text = listCmLogComplains[0].TxnDate.ToString();


        }
        
        protected void btnDone_Click(object sender, EventArgs e)
        {
           
            //confirmBox.Visible = true;
            LinkButton button = (LinkButton)sender;
            string doneid = button.CommandArgument;

            CmLogComplains done = new CmLogComplains();
            done.Status = doneid;

            Session["userId"] = done.Status;
            //objDone.Status = doneid;

            //complainData = done.Status;
            popup.Visible = true;


            //ICmLogComplainsController cmLogComplainsController = ControllerFactory.CreateCmLogComplainsDAO();
            //cmLogComplainsController.DoneCmLogComplains(done);

            //Response.AppendHeader("Refresh", "5; URL=ComplainDashboard.aspx");


        }
        
        protected void donePopup(object sender, EventArgs e)
        {
            CmLogComplains donePop = new CmLogComplains();
            donePop.Status = (string)Session["userId"];
            //donePop.Status = complainData;

            ICmLogComplainsController cmLogComplainsController = ControllerFactory.CreateCmLogComplainsDAO();
            cmLogComplainsController.DoneCmLogComplains(donePop);

            popup.Visible = false;

            Response.AppendHeader("Refresh", "5; URL=ComplainDashboard.aspx?id=" + Session["pnbs_id"]);
         
        }
        
        protected void cancelPopup(object sender, EventArgs e)
        {
            popup.Visible = false;
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
      

        protected void btn_ReSave(object sender, EventArgs e)
        {
            ComplainRemarks compRemarks = new ComplainRemarks();
            CmLogComplains complains = new CmLogComplains();

            compRemarks.CompId = comp_id.Text;
            compRemarks.SectionId = ddlSectionMaster.SelectedValue;

            string currentDateString = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime currentDate = DateTime.Parse(currentDateString);
            compRemarks.ReInfoDate = currentDate;

            compRemarks.MyRemarks = my_remarks.Text;

            IComplainRemarksController complainRemarksController = ControllerFactory.CreateComplainRemarksDetailController();
            complainRemarksController.Save(compRemarks);

            //send to note

            complains.Note = my_remarks.Text;
            complains.InfoTo = ddlSectionMaster.SelectedValue;
            complains.CompId = comp_id.Text;

            ICmLogComplainsController cmLogComplainsController = ControllerFactory.CreateCmLogComplainsDAO();
            cmLogComplainsController.Update(complains);

            ClearMe();
        }
        private void ClearMe()
        {
            my_remarks.Text = string.Empty;
            

        }
        protected void backToDashboard(object sender, EventArgs e)
        {
            dvView_More.Visible = false;
        }
        
        protected void backToGridView(object sender, EventArgs e)
        {
            dvCompRemarks_grid.Visible = false;
        }

        //sorting part
        protected void gridView_Sorting(object sender, GridViewSortEventArgs e)
        {
            // Sort the data source
            SortDataSource(e.SortExpression);
            // Rebind the gridview
            GridView.DataBind();
        }

        private void SortDataSource(string sortExpression)
        {
            ICmLogComplainsController cmLogComplainsController = ControllerFactory.CreateCmLogComplainsDAO();
            var dataSource = cmLogComplainsController.ViewMoreCmLogComplains(ComplainSort);
        
            //var dataSource = GetDataSource();
          
            //dataSource.Sort(sortExpression, SortDirection.Ascending);
       
            GridView.DataSource = dataSource;
        }
    


    }
}