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
    public partial class EditAlternateContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AlternateContactUC.FirstName.Text = AppData.Instance.AltContact.FirstName;
                AlternateContactUC.LastName.Text = AppData.Instance.AltContact.LastName;
                AlternateContactUC.Relationship.Text = AppData.Instance.AltContact.Relationship;
                AlternateContactUC.PhoneNumber.Text = AppData.Instance.AltContact.PhoneNumber;
            }
        }

        protected void btUpdate_Click(object sender, EventArgs e)
        {
            AppData.Instance.AltContact.FirstName = AlternateContactUC.FirstName.Text;
            AppData.Instance.AltContact.LastName = AlternateContactUC.LastName.Text;
            AppData.Instance.AltContact.Relationship = AlternateContactUC.Relationship.Text;
            AppData.Instance.AltContact.PhoneNumber = AlternateContactUC.PhoneNumber.Text;
            AlternateContactRepository altContRepos = new AlternateContactRepository();
            lbResult.Text = altContRepos.UpdateAltContact(AppData.Instance.AltContact, AppData.Instance.customer.CustomerID);
        }
    }
}