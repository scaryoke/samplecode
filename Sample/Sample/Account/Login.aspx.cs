using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration; 

namespace Sample.Account 	
{
    public partial class Login : AppDriver
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RegisterHyperLink.NavigateUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (Membership.ValidateUser(LoginUser.UserName, LoginUser.Password))
            {
                if (SetUp(LoginUser.UserName))
                {
                    FormsAuthentication.SetAuthCookie(LoginUser.UserName, false);
                    HttpContext.Current.Session["UserId"] = LoginUser.UserName;
                    HttpContext.Current.Session.Timeout = 10;
                    string continueUrl = RegisterHyperLink.NavigateUrl;
                    if (String.IsNullOrEmpty(continueUrl))
                    {
                        continueUrl = "~/";
                    }
                    Response.Redirect(continueUrl);
                }
                else
                {
                    HttpContext.Current.Session.Abandon();
                }
            }
        }
    }
}
