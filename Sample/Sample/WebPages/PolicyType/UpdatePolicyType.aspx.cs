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
    public partial class UpdatePolicyType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PolicyTypeUC.TbPolicyType.Text = AppData.Instance.policyType.PolicyTypeName;
                PolicyTypeUC.TbPolicyTypeDesc.Text = AppData.Instance.policyType.PolicyTypeDesc;
            }
        }

        protected void EditPolicyType_Click(object sender, EventArgs e)
        {
            AppData.Instance.policyType.PolicyTypeName = PolicyTypeUC.TbPolicyType.Text;
            AppData.Instance.policyType.PolicyTypeDesc = PolicyTypeUC.TbPolicyTypeDesc.Text;
            PolicyTypeRepository polTypeRepos = new PolicyTypeRepository();
            lbResult.Text = polTypeRepos.UpdatePolicyType(AppData.Instance.policyType);
        }
    }
}