using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Sample
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //if (!HttpContext.Current.User.Identity.IsAuthenticated || HttpContext.Current.Session["UserId"] == null)
                //{
                //    FormsAuthentication.SignOut();
                //    Response.Redirect("~/Account/Login.aspx");
                //}
            }
            catch (Exception ex)
            {
                //FormsAuthentication.SignOut();
                //if (!HttpContext.Current.User.Identity.IsAuthenticated || HttpContext.Current.Session["UserId"] == null)
                //{
                //    FormsAuthentication.SignOut();
                //    Response.Redirect("~/Account/Login.aspx");
                //}
                //else
                //{
                    Response.Redirect("~/Default.aspx");
                //}
            }
        }
    }
}
