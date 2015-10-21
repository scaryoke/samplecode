using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample.UserControls
{
    public partial class CompanyUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public TextBox CompanyName
        {
            get { return tbCompany; }
        }

        public TextBox ContactNum
        {
            get { return tbContactNum; }
        }
    }
}