using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Sample.UserControls
{
    public partial class PolicyTypeUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public TextBox TbPolicyType
        {
            get { return tbPolicyType; }
        }

        public TextBox TbPolicyTypeDesc
        {
            get { return tbPolicyDesc; }
        }
    }
}