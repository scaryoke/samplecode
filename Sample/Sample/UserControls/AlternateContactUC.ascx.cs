﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample.UserControls
{
    public partial class AlternateContactUC : System.Web.UI.UserControl
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

        public TextBox Relationship
        {
            get { return tbRelationship; }
        }

        public TextBox PhoneNumber
        {
            get { return tbContactNum; }
        }
    }
}