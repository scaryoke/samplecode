using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.PolicyType
{
    public partial class SearchPolicyTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PolicyTypeRepository polTypeRepos = new PolicyTypeRepository();
                PolicyTypeView.DataSource = polTypeRepos.GetAllPolicyTypes();
                PolicyTypeView.DataBind();
            }
        }

        protected void policyTypeView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int Index = Convert.ToInt32(e.CommandArgument.ToString());
            AppData.Instance.policyType.PolicyTypeName = AppData.Instance.policyType.PolicyTypeTable.Rows[Index]["PolicyType"].ToString();
            AppData.Instance.policyType.PolicyTypeDesc = AppData.Instance.policyType.PolicyTypeTable.Rows[Index]["PolicyTypeDescription"].ToString();
            AppData.Instance.policyType.PolicyTypeID = Convert.ToInt32(AppData.Instance.policyType.PolicyTypeTable.Rows[Index]["PolicyType_ID"].ToString());
            Response.Redirect("~/WebPages/PolicyType/UpdatePolicyType.aspx");
        }
    }
}