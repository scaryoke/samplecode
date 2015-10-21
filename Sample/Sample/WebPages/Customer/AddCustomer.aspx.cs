using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Customer
{
    public partial class AddCustomer : AppDriver
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (HttpContext.Current.Session["UserId"] == null)
            //    Response.Redirect("~/Account/Login.aspx");
           
            // DateTime date = DateTime(Convert.ToInt32tbDate.Text);
            //Button1.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                lbError.Visible = false;
                AppData.Instance.customer.ID = 1;
                AppData.Instance.customer.LastName = CustomerUC.LastName.Text;
                AppData.Instance.customer.FirstName = CustomerUC.FirstName.Text;
                AppData.Instance.customer.SSN = CustomerUC.SSN.Text;
                AppData.Instance.customer.Address = CustomerUC.Address.Text;
                AppData.Instance.customer.County = CustomerUC.County.Text;
                AppData.Instance.customer.DOB = CustomerUC.DOB.Text;
                AppData.Instance.customer.MiddleInitial = CustomerUC.MiddleInitial.Text;
                AppData.Instance.customer.Notes = string.IsNullOrEmpty(CustomerUC.Notes.Text) ? "" : CustomerUC.Notes.Text;
                AppData.Instance.customer.PhoneNumber = CustomerUC.PhoneNumber.Text;
                AppData.Instance.customer.SpouseFirst = string.IsNullOrEmpty(CustomerUC.SpouseFirst.Text) ? "" : CustomerUC.SpouseFirst.Text;
                AppData.Instance.customer.SpouseLast = string.IsNullOrEmpty(CustomerUC.SpouseLast.Text) ? "" : CustomerUC.SpouseLast.Text;
                AppData.Instance.customer.State = CustomerUC.State.Text;
                AppData.Instance.customer.Town = CustomerUC.Town.Text;
                AppData.Instance.customer.ZipCode = CustomerUC.ZipCode.Text;
                Validator.ValidateObject(AppData.Instance.customer, new ValidationContext(AppData.Instance.customer, null, null), true);
                CustomerUC.SSN.Text = "******" + CustomerUC.SSN.Text.Substring(5);
                lbAnswer.Text = "Is this information correct?";
                btYes.Visible = true;
                btNo.Visible = true;
                Button1.Visible = false;
            }
            catch (ArgumentOutOfRangeException aoorEx)
            {
                lbError.Visible = true;
                lbError.Text = "Missing Value";
            }
            catch (ValidationException ex)
            {
                lbError.Visible = true;
                lbError.Text = ex.Message;
            }
        }

        protected void btYes_Click(object sender, EventArgs e)
        {
            CustomerRepository cRepos = new CustomerRepository();
            lbAnswer.Text = cRepos.AddCustomer(AppData.Instance.customer);
            btYes.Visible = false;
            btNo.Visible = false; 
            btAltNo.Visible = true;
            btAlt.Visible = true;
            btMedicare.Visible = true;
        }

        protected void btNo_Click(object sender, EventArgs e)
        {
            lbAnswer.Text = string.Empty;
            btYes.Visible = false;
            btNo.Visible = false;
            Button1.Visible = true;
            //btMedicare.Visible = true;
        }

        protected void btAlt_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/AlternateContact/AlternateContact.aspx");
        }

        protected void btAltNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/Policy/AddPolicy.aspx");
        }

        protected void btMedicare_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/Medicare/AddMedicare.aspx");
        }

    }
}