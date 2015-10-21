using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Medicare
{
    public partial class UpdateMedicare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MedicareRepository medRepos = new MedicareRepository();
                DataTable dt = medRepos.GetMedicare(AppData.Instance.customer.CustomerID);

                if (dt.Rows.Count > 0)
                {
                    MedicareUC.MediCard.Text = dt.Rows[0]["MedicareCardNumber"].ToString();
                    MedicareUC.MediADate.Text = dt.Rows[0]["MedicareA_DateEnrolled"].ToString();
                    MedicareUC.MediBDate.Text = dt.Rows[0]["MedicareB_DateEnrolled"].ToString();
                    lbHeader.Text = string.Format("Edit Medicare Information for {0} {1}", AppData.Instance.customer.FirstName, AppData.Instance.customer.LastName);
                    AppData.Instance.medicare.Add = false;
                }
                else
                {
                    lbHeader.Text = string.Format("Add Medicare Information for {0} {1}", AppData.Instance.customer.FirstName, AppData.Instance.customer.LastName);
                    btEditMedicare.Text = "Add Medicare Information";
                    AppData.Instance.medicare.Add = true;
                }
            }
        }

        protected void btEditMedicare_Click(object sender, EventArgs e)
        {

            MedicareRepository medRepos = new MedicareRepository();
            AppData.Instance.medicare.MedicareCard = MedicareUC.MediCard.Text;
            AppData.Instance.medicare.MedicareDateA = MedicareUC.MediADate.Text;
            AppData.Instance.medicare.MedicareDateB = string.IsNullOrEmpty(MedicareUC.MediBDate.Text) ? "" : MedicareUC.MediBDate.Text;
            if (AppData.Instance.medicare.Add)
            {
                lbResult.Text = medRepos.AddMedicare(AppData.Instance.medicare, AppData.Instance.customer.CustomerID);
            }
            else
            {
                lbResult.Text = medRepos.UpdateMedicare(AppData.Instance.medicare, AppData.Instance.customer.CustomerID);
            }
            
        }
    }
}