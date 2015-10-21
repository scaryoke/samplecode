using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sample.ClassLib;

namespace Sample.ClassLib
{
    public class AppData
    {
        public AppData()
        {
        }
        public string SessionID { get; set; }
        public static AppData Instance
        {
            get
            {
                AppData appData = null;
                if (HttpContext.Current.Session["AppData"] != null)
                {
                    appData = (AppData)HttpContext.Current.Session["AppData"];
                }
                else
                {
                    appData = new AppData();
                    HttpContext.Current.Session["AppData"] = appData;
                }
                return appData;
            }
        }

        public Customer customer = new Customer();

        public Company company = new Company();

        public PolicyType policyType = new PolicyType();

        public Policy policy = new Policy();

        public Employee employee = new Employee();

        public AlternateContact AltContact = new AlternateContact();

        public Medicare medicare = new Medicare();

        public Reports reports = new Reports();
    }
}