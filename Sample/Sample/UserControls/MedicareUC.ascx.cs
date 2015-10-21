using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample.UserControls
{
    public partial class MedicareUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public TextBox MediCard
        {
            get { return tbMediCard; }
        }

        public TextBox MediADate
        {
            get { return tbDateA; }
        }

        public TextBox MediBDate
        {
            get { return tbDateB; }
        }
    }
}