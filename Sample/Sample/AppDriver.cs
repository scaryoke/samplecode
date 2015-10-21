using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample
{
    public class AppDriver : System.Web.UI.Page
    {
        protected internal AppData appData = null;
        public bool SetUp(string userName)
        {
            AppData.Instance.SessionID = HttpContext.Current.Session.SessionID;
            EmployeeRepository empRepos = new EmployeeRepository();
            if (empRepos.GetEmployee(userName))
            {
                AppData.Instance.employee.UserName = userName;
                return true;
            }
            else
                return false;
        }

        
    }
}