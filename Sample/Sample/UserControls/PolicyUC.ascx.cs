using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample
{
    public partial class PolicyUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Label Header
        {
            get { return lbTitle; }
        }

        public TextBox PolicyNumber
        {
            get { return tbPolicyNumber; }
        }

        public TextBox AgeAtIssue
        {
            get { return tbAge; }
        }

        public DropDownList Company
        {
            get { return ddList; }
        }

        public DropDownList PolicyType
        {
            get { return policyTypeList; }
        }

        public TextBox DateWritten
        {
            get { return tbDateWritten; }
        }

        public TextBox DateEffective
        {
            get { return tbDateEffective; }
        }

        public TextBox PolicyStatus
        {
            get { return tbPolicyStatus; }
        }

        public TextBox Commission
        {
            get { return tbCommission; }
        }

        public TextBox Renewal
        {
            get { return tbRenewal; }
        }

        public DropDownList Billing
        {
            get { return ddBilling; }
        }

        public TextBox Premium
        {
            get { return tbPremium; }
        }

        public DropDownList PolicyHolder
        {
            get { return Primary; }
        }
    }
}