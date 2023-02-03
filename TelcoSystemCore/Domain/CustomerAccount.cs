using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelcoSystemCore.Common;

namespace TelcoSystemCore.Domain
{
    [Serializable]
    public class CustomerAccount
    {
        [DBField("top_customer_stat")]
        public string topCusStat { get; set; }

        [DBField("reminder_pd")]
        public string reminderPd { get; set; }

        [DBField("rental_category")]
        public string rentalCategory { get; set; }

        [DBField("pre_paid")]
        public string prePaid { get; set; }

        [DBField("switch_type")]
        public string switchType { get; set; }

        [DBField("credit_limit")]
        public int creditLimit { get; set; }

        [DBField("disconnect_stst")]
        public string disconnectStat { get; set; }

        [DBField("stat_after_days")]
        public string statAfterDays { get; set; }

        [DBField("grace_period")]
        public DateTime gracePeriod { get; set; }

        [DBField("allocated_sales_person ")]
        public string allocatedSalesPerson { get; set; }

        [DBField("revenue_region")]
        public string revenueRegion { get; set; }

        [DBField("email")]
        public string email { get; set; }

        [DBField("indirect_br")]
        public string indirectBr { get; set; }

        [DBField("mobile_number")]
        public string mobileNumber { get; set; }

        [DBField("policy_apply_date")]
        public DateTime policyApplyDate { get; set; }

        [DBField("customer_type_id")]
        public string cusTypeId { get; set; }

        [DBField("account_id")]
        public string accountId { get; set; }

        [DBField("account_name")]
        public string accountName { get; set; }

        [DBField("customer_id")]
        public string customerId { get; set; }

        [DBField("priority_id")]
        public string priorityId { get; set; }

        [DBField("company_id")]
        public string companyId { get; set; }

        [DBField("current_balance")]
        public double currentBalance { get; set; }

        [DBField("connect_status_id")]
        public string connectStatusId { get; set; }

        [DBField("cr_credit_rating_code")]
        public string crCreditRatingCode { get; set; }

        [DBField("ac_account_category")]
        public string acAccountCategory { get; set; }

        [DBField("title")]
        public string title { get; set; }

        [DBField("address_line_1")]
        public string addressLine1 { get; set; }

        [DBField("address_line_2")]
        public string addressLine2 { get; set; }

        [DBField("address_line_3")]
        public string addressLine3 { get; set; }

        [DBField("city")]
        public string city { get; set; }

        [DBField("postal_code")]
        public string postalCode { get; set; }

        [DBField("introduced_by")]
        public string introducedBy { get; set; }

        [DBField("introduced_on")]
        public DateTime introducedOn { get; set; }

        [DBField("last_modified_by")]
        public string lastModifiedBy { get; set; }

        [DBField("last_modified_on")]
        public DateTime lastModifiedOn { get; set; }

        [DBField("bill_run_code")]
        public double billRunCode { get; set; }

        [DBField("deactivated_by")]
        public string deactivatedBy { get; set; }

        [DBField("deactivated_on")]
        public DateTime deactivatedOn { get; set; }

        [DBField("ledger_cd")]
        public string ledgerCd { get; set; }

        [DBField("acct_type")]
        public string acct_Type { get; set; }

        [DBField("opening_balance")]
        public double openingBalance { get; set; }

        [DBField("control_account")]
        public string controlAccount { get; set; }

        [DBField("bill_run_stat")]
        public string billRunStat { get; set; }

        [DBField("team_no")]
        public int teamNo { get; set; }

        [DBField("sales_person")]
        public string salesPerson { get; set; }

        [DBField("collector")]
        public string collector { get; set; }

        [DBField("province")]
        public string province { get; set; }

        [DBField("district")]
        public string district { get; set; }

        [DBField("priority_val")]
        public int priorityVal { get; set; }

        [DBField("major_industry")]
        public string majorIndustry { get; set; }

        [DBField("minor_industry")]
        public string minorIndustry { get; set; }

        [DBField("prv_ac_account_category")]
        public string prvAcAccountCategory { get; set; }

        [DBField("cus_comment_checked")]
        public string cusCommentChecked { get; set; }

        [DBField("confidential")]
        public string confidential { get; set; }

        [DBField("status_changed_on")]
        public DateTime statusChangedOn { get; set; }

        [DBField("discon_avoid_date")]
        public DateTime disconAvoidDate { get; set; }

        [DBField("top_customer_stat")]
        public string topcustomerStat { get; set; }

        [DBField("policy_apply_date")]
        public DateTime posicyApplyDate { get; set; }

        [DBField("customer_type_id")]
        public string customerTypeId { get; set; }
    }
}
