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
    public partial class AddPolicyType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAddPolicyType_Click(object sender, EventArgs e)
        {
            AppData.Instance.policyType.PolicyTypeName = PolicyTypeUC.TbPolicyType.Text;
            AppData.Instance.policyType.PolicyTypeDesc = PolicyTypeUC.TbPolicyTypeDesc.Text;
            PolicyTypeRepository pTypeRepository = new PolicyTypeRepository();
            lbResult.Text = pTypeRepository.AddPolicyType(AppData.Instance.policyType);
        }
    }
}