using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Medicare
{
    public partial class AddMedicare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                lbHeader.Text = string.Format("For {0} {1}", AppData.Instance.customer.FirstName, AppData.Instance.customer.LastName);
        }

        protected void btAddMedicare_Click(object sender, EventArgs e)
        {
            AppData.Instance.medicare.MedicareCard = MedicareUC.MediCard.Text;
            AppData.Instance.medicare.MedicareDateA = MedicareUC.MediADate.Text;
            AppData.Instance.medicare.MedicareDateB = string.IsNullOrEmpty(MedicareUC.MediBDate.Text) ? "" : MedicareUC.MediBDate.Text;

            MedicareRepository mediRepos = new MedicareRepository();
            lbAnswer.Text = mediRepos.AddMedicare(AppData.Instance.medicare, AppData.Instance.customer.CustomerID);
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
            Response.Redirect("~/WebPages/AlternateContact/AlternateContact.aspx");
        }
    }
}