using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Customer
{
    public partial class UpdateCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CustomerUC.LastName.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["CustomerLastName"].ToString();
                CustomerUC.FirstName.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["CustomerFirstName"].ToString();
                CustomerUC.MiddleInitial.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["MiddleInitial"].ToString();
                CustomerUC.SSN.Text = string.Format("*****{0}",AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["SSN"].ToString().Substring(5));
                CustomerUC.Address.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["Street"].ToString();
                CustomerUC.County.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["County"].ToString();
                CustomerUC.DOB.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["DateofBirth"].ToString();
                CustomerUC.PhoneNumber.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["PhoneNumber"].ToString();
                CustomerUC.Notes.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["CustomerNotes"].ToString();
                CustomerUC.Town.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["City"].ToString();
                CustomerUC.State.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["State"].ToString();
                CustomerUC.ZipCode.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["ZipCode"].ToString();
                CustomerUC.SpouseFirst.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["SpouseFName"].ToString();
                CustomerUC.SpouseLast.Text = AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["SpouseLName"].ToString();
                AppData.Instance.customer.CustomerID = Convert.ToInt32(AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["Customer_ID"].ToString());
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                lbError.Visible = false;
                AppData.Instance.customer.LastName = CustomerUC.LastName.Text;
                AppData.Instance.customer.FirstName = CustomerUC.FirstName.Text;
                AppData.Instance.customer.SSN = CustomerUC.SSN.Text;
                AppData.Instance.customer.Address = CustomerUC.Address.Text;
                AppData.Instance.customer.County = CustomerUC.County.Text;
                AppData.Instance.customer.DOB = CustomerUC.DOB.Text;
                AppData.Instance.customer.MiddleInitial = CustomerUC.MiddleInitial.Text;
                AppData.Instance.customer.Notes = CustomerUC.Notes.Text;
                AppData.Instance.customer.PhoneNumber = CustomerUC.PhoneNumber.Text;
                AppData.Instance.customer.SpouseFirst = CustomerUC.SpouseFirst.Text;
                AppData.Instance.customer.SpouseLast = CustomerUC.SpouseLast.Text;
                AppData.Instance.customer.State = CustomerUC.State.Text;
                AppData.Instance.customer.Town = CustomerUC.Town.Text;
                AppData.Instance.customer.ZipCode = CustomerUC.ZipCode.Text;
                AppData.Instance.customer.CustomerID = Convert.ToInt32(AppData.Instance.customer.dt.Rows[AppData.Instance.customer.ID]["Customer_ID"].ToString());
                CustomerUC.SSN.Text = "******" + CustomerUC.SSN.Text.Substring(5);
                lbAnswer.Text = "Is this information correct?";
                btYes.Visible = true;
                btNo.Visible = true;
                Button1.Visible = false;
            }
            catch (ArgumentOutOfRangeException aoorEx)
            {
                lbError.Visible = true;
                lbError.Text = "Missing Value";
            }
        }

        protected void btYes_Click(object sender, EventArgs e)
        {
            CustomerRepository cRepos = new CustomerRepository();
            //lbAnswer.Text = cRepos.UpdateCustomer(AppData.Instance.customer);
            btYes.Visible = false;
            btNo.Visible = false;
            btAltNo.Visible = true;
            btAlt.Visible = true;
            btMedicare.Visible = true;
        }

        protected void btNo_Click(object sender, EventArgs e)
        {
            lbAnswer.Text = string.Empty;
            btYes.Visible = false;
            btNo.Visible = false;
            Button1.Visible = true;
        }

        protected void btAlt_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/AlternateContact/SearchAlternateContact.aspx");
        }

        protected void btAltNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/Policy/SearchPolicies.aspx");
        }

        protected void btMedicare_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/Medicare/AddMedicare.aspx");
        }
    }
}