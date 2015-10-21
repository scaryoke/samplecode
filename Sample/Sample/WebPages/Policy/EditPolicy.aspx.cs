using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Policy
{
    public partial class EditPolicy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PolicyRepository polRepos = new PolicyRepository();
                AppData.Instance.policy.CompanyName = polRepos.GetCompanies();
                AppData.Instance.policy.PolicyType = polRepos.GetPolicyTypes();
                foreach (DataRow row in AppData.Instance.policy.CompanyName.Rows)
                {
                    PolicyUC.Company.Items.Add(new ListItem(row["Company"].ToString(), row["Company_ID"].ToString()));
                }
                foreach (DataRow row in AppData.Instance.policy.PolicyType.Rows)
                {
                    PolicyUC.PolicyType.Items.Add(new ListItem(row["PolicyType"].ToString(), row["PolicyType_ID"].ToString()));
                }
                PolicyUC.Company.SelectedIndex = AppData.Instance.policy.CompanyID - 1;
                PolicyUC.PolicyType.SelectedIndex = AppData.Instance.policy.PolicyTypeID - 1;
                PolicyUC.Header.Text = string.Format("Policy for {0} {1}", AppData.Instance.customer.FirstName, AppData.Instance.customer.LastName);
                PolicyUC.AgeAtIssue.Text = AppData.Instance.policy.AgeAtIssue;
                PolicyUC.Billing.SelectedValue = AppData.Instance.policy.Billing;
                PolicyUC.Commission.Text = AppData.Instance.policy.CommissionPercentage.ToString();
                PolicyUC.DateEffective.Text = AppData.Instance.policy.DateEffective.ToString("MM/dd/yyyy");
                PolicyUC.DateWritten.Text = AppData.Instance.policy.DateWritten.ToString("MM/dd/yyyy");
                PolicyUC.PolicyHolder.SelectedValue = AppData.Instance.policy.PolicyHolder;
                PolicyUC.PolicyNumber.Text = AppData.Instance.policy.PolicyNumber;
                PolicyUC.PolicyStatus.Text = AppData.Instance.policy.PolicyStatus;
                PolicyUC.Premium.Text = AppData.Instance.policy.Premium.ToString();
                PolicyUC.Renewal.Text = AppData.Instance.policy.Renewal.ToString();
            }
        }

        protected void UpdatePolicy_Click(object sender, EventArgs e)
        {
            AppData.Instance.policy.AgeAtIssue = PolicyUC.AgeAtIssue.Text;
            AppData.Instance.policy.CommissionPercentage = Convert.ToDouble(PolicyUC.Commission.Text);
            AppData.Instance.policy.CompanyID = Convert.ToInt32(PolicyUC.Company.SelectedValue);
            DateTime date;
            if (DateTime.TryParse(PolicyUC.DateEffective.Text, out date))
                AppData.Instance.policy.DateEffective = date;
            if (DateTime.TryParse(PolicyUC.DateWritten.Text, out date))
                AppData.Instance.policy.DateWritten = date;
            AppData.Instance.policy.PolicyNumber = PolicyUC.PolicyNumber.Text;
            AppData.Instance.policy.PolicyStatus = PolicyUC.PolicyStatus.Text;
            AppData.Instance.policy.PolicyTypeID = Convert.ToInt32(PolicyUC.PolicyType.SelectedValue);
            AppData.Instance.policy.Renewal = Convert.ToDouble(PolicyUC.Renewal.Text);
            AppData.Instance.policy.PolicyHolder = PolicyUC.PolicyHolder.SelectedValue;
            AppData.Instance.policy.PolicyNumber = PolicyUC.PolicyNumber.Text;
            AppData.Instance.policy.PolicyStatus = PolicyUC.PolicyStatus.Text;
            AppData.Instance.policy.PolicyTypeID = Convert.ToInt32(PolicyUC.PolicyType.SelectedValue);
            AppData.Instance.policy.Premium = Convert.ToDouble(PolicyUC.Premium.Text);
            AppData.Instance.policy.Renewal = Convert.ToDouble(PolicyUC.Renewal.Text);
            AppData.Instance.policy.Billing = PolicyUC.Billing.SelectedValue;
            lbAnswer.Text = "Is this information correct?";
            btYes.Visible = true;
            btNo.Visible = true;
        }

        protected void btYes_Click(object sender, EventArgs e)
        {
            PolicyRepository polRepos = new PolicyRepository();
            lbAnswer.Text = polRepos.UpdatePolicy(AppData.Instance.policy);
            //Response.Redirect("~/WebPages/Policy/AddPolicy.aspx");
        }

        protected void btNo_Click(object sender, EventArgs e)
        {
            lbAnswer.Text = string.Empty;
            btYes.Visible = false;
            btNo.Visible = false;
        }
    }
}