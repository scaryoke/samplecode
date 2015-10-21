using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Policy
{
    public partial class SearchPolicies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PolicyRepository polRepos = new PolicyRepository();
                DataTable dt = polRepos.GetPolicies(AppData.Instance.customer.CustomerID);
                if (dt.Rows.Count == 0)
                    Response.Redirect("~/WebPages/Policy/AddPolicy.aspx");
                PolicyView.DataSource = dt;
                PolicyView.DataBind();
            }
        }

        protected void PolicyView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int Index = Convert.ToInt32(e.CommandArgument.ToString());
            AppData.Instance.policy.AgeAtIssue = AppData.Instance.policy.PolicyList.Rows[Index]["AgeAtIssue"].ToString();
            AppData.Instance.policy.Billing = AppData.Instance.policy.PolicyList.Rows[Index]["BillingPeriod"].ToString();
            AppData.Instance.policy.CommissionPercentage = Convert.ToDouble(AppData.Instance.policy.PolicyList.Rows[Index]["CommissionPercentage"].ToString());
            AppData.Instance.policy.CompanyID = Convert.ToInt32(AppData.Instance.policy.PolicyList.Rows[Index]["Company_ID"].ToString());
            AppData.Instance.policy.DateEffective = Convert.ToDateTime(AppData.Instance.policy.PolicyList.Rows[Index]["EffectiveDate"].ToString());
            AppData.Instance.policy.DateWritten = Convert.ToDateTime(AppData.Instance.policy.PolicyList.Rows[Index]["DateWritten"].ToString());
            AppData.Instance.policy.InitialPercentage = Convert.ToDouble(AppData.Instance.policy.PolicyList.Rows[Index]["InitialPercentage"].ToString());
            AppData.Instance.policy.PolicyHolder = AppData.Instance.policy.PolicyList.Rows[Index]["BillingPeriod"].ToString();
            AppData.Instance.policy.PolicyNumber = AppData.Instance.policy.PolicyList.Rows[Index]["PolicyNumber"].ToString();
            AppData.Instance.policy.PolicyStatus = AppData.Instance.policy.PolicyList.Rows[Index]["PolicyStatus"].ToString();
            AppData.Instance.policy.PolicyTypeID = Convert.ToInt32(AppData.Instance.policy.PolicyList.Rows[Index]["PolicyType_ID"].ToString());
            AppData.Instance.policy.Premium = Convert.ToDouble(AppData.Instance.policy.PolicyList.Rows[Index]["PremiumAmt"].ToString());
            AppData.Instance.policy.Renewal = Convert.ToDouble(AppData.Instance.policy.PolicyList.Rows[Index]["Renewal"].ToString());
            AppData.Instance.policy.PolicyID = Convert.ToInt32(AppData.Instance.policy.PolicyList.Rows[Index]["Policy_ID"].ToString());
            Response.Redirect("~/WebPages/Policy/EditPolicy.aspx");
        }

        protected void btAddPolicy_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/Policy/AddPolicy.aspx");
        }
    }
}