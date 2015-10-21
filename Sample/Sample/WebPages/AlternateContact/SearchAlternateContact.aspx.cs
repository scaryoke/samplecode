using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.AlternateContact
{
    public partial class SearchAlternateContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AlternateContactRepository altContRepos = new AlternateContactRepository();
                DataTable dt = altContRepos.GetAltContact(AppData.Instance.customer.CustomerID);
                AltContactView.DataSource = dt;
                AltContactView.DataBind();
                if (dt.Rows.Count == 0)
                    lbAltMessage.Text = string.Format("There are no alternate contacts for {0} {1}. Click below to add an alternate contact.", AppData.Instance.customer.FirstName, AppData.Instance.customer.LastName);
                else
                    lbAltMessage.Text = string.Format("Add a new alternate contact for {0} {1}.", AppData.Instance.customer.FirstName, AppData.Instance.customer.LastName);
               
            }
        }

        protected void AltContactView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int Index = Convert.ToInt32(e.CommandArgument.ToString());
            AppData.Instance.AltContact.FirstName = AppData.Instance.AltContact.AltContactDT.Rows[Index]["AltFirstName"].ToString();
            AppData.Instance.AltContact.LastName = AppData.Instance.AltContact.AltContactDT.Rows[Index]["AltLastName"].ToString();
            AppData.Instance.AltContact.Relationship = AppData.Instance.AltContact.AltContactDT.Rows[Index]["Relationship"].ToString();
            AppData.Instance.AltContact.PhoneNumber = AppData.Instance.AltContact.AltContactDT.Rows[Index]["AltPhone"].ToString();
            AppData.Instance.AltContact.AltContactID = Convert.ToInt32(AppData.Instance.AltContact.AltContactDT.Rows[Index]["AltContact_ID"].ToString());
            Response.Redirect("~/WebPages/AlternateContact/EditAlternateContact.aspx");
        }

        protected void btAddAlt_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/AlternateContact/AlternateContact.aspx");
        }
    }
}