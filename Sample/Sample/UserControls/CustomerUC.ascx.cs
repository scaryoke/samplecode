using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public TextBox FirstName
        {
            get { return tbFirstName; }
        }

        public TextBox LastName
        {
            get { return tbLastName; }
        }

        public TextBox MiddleInitial
        {
            get { return tbMI; }
        }

        public TextBox SSN
        {
            get { return tbSSN; }
        }

        public TextBox DOB
        {
            get { return tbDOB; }
        }

        public TextBox Address
        {
            get { return tbStreet; }
        }

        public TextBox Town
        {
            get { return tbCity; }
        }

        public TextBox ZipCode
        {
            get { return tbZipCode; }
        }

        public TextBox County
        {
            get { return tbCounty; }
        }

        public TextBox State
        {
            get { return tbState; }
        }

        public TextBox PhoneNumber
        {
            get { return tbPhoneNum; }
        }

        public TextBox SpouseFirst
        {
            get { return tbSpouseFirst; }
        }

        public TextBox SpouseLast
        {
            get { return tbSpouseLast; }
        }

        public TextBox Notes
        {
            get { return tbNotes; }
        }
    }
}