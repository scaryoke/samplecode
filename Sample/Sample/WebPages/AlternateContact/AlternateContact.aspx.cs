using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.AlternateContact
{
    public partial class AlternateContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                lbSpouse.Text = string.Format("Alternate Contact for {0} {1}", AppData.Instance.customer.FirstName, AppData.Instance.customer.LastName);
        }
        protected void btYes_Click(object sender, EventArgs e)
        {

            //lbAnswer.Text = "Is this information correct?";
            btYes.Visible = false;
            btNo.Visible = false;
            AlternateContactRepository altConRepos = new AlternateContactRepository();
            lbAnswer.Text = altConRepos.AddAltContact(AppData.Instance.AltContact, AppData.Instance.customer.CustomerID);
            btYes.Visible = false;
            btNo.Visible = false;
            btAddAnother.Visible = true;
        }

        protected void btNo_Click(object sender, EventArgs e)
        {
            lbAnswer.Text = string.Empty;
            btYes.Visible = false;
            btNo.Visible = false;
           
        }

        protected void btAddAltContact_Click(object sender, EventArgs e)
        {

            lbAnswer.Text = "Is this information correct?";
            btYes.Visible = true;
            btNo.Visible = true;
            btAddAltContact.Visible = false;
            AppData.Instance.AltContact.FirstName = AlternateContactUC.FirstName.Text;
            AppData.Instance.AltContact.LastName = AlternateContactUC.LastName.Text;
            AppData.Instance.AltContact.Relationship = AlternateContactUC.Relationship.Text;
            AppData.Instance.AltContact.PhoneNumber = AlternateContactUC.PhoneNumber.Text;
        }

        protected void btAddAnother_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/AlternateContact/AlternateContact.aspx");
        }

        protected void btReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void btAddPolicy_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/Policy/AddPolicy.aspx");
        }

        protected void btAddAlt_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/Medicare/AddMedicare.aspx");
        }
    }
}