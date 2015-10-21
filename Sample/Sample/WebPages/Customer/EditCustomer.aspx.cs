using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Customer
{
    public partial class EditCustomer : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Customer cUstomer = new Customer();

                //DataView dv = new DataView(cUstomer.dt);
                //customer.DataSource = dv;
                //customer.DataBind();
            }
        }

        protected void btSearch_Click(object sender, EventArgs e)
        {

            string SearchVal = tbSearchValue.Text;
            string SpName = Convert.ToString(ddStuff.SelectedValue);

            CustomerRepository CustRepos = new CustomerRepository();
            
            customer.DataSource = CustRepos.SearchCustomer(SpName, SearchVal);
            lbData.Text = SpName;
            lbData.Text = AppData.Instance.customer.StoredProcResult;
            customer.DataBind();

            //customer.Columns[4].Visible = false;
        }

        protected void customer_ItemCommand(object source, GridViewCommandEventArgs e)
        {

            if (((ButtonField)e.CommandSource).CommandName == "EditCustomer")
            {
                AppData.Instance.customer.ID = Convert.ToInt32(customer.SelectedRow.ToString());
                Response.Redirect("~/WebPages/Customer/UpdateCustomer.aspx");
            }
            else
            {
                Response.Redirect("~/WebPages/Policy/SearchPolicies.aspx");
            }
        }

        protected void customer_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //lbData.Text = Convert.ToString(e.CommandArgument);
            //Response.Redirect("~/UpdateCustomer.aspx");
            AppData.Instance.customer.LastName = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["CustomerLastName"].ToString();
            AppData.Instance.customer.FirstName = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["CustomerFirstName"].ToString();
            AppData.Instance.customer.MiddleInitial = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["MiddleInitial"].ToString();
            AppData.Instance.customer.SSN = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["SSN"].ToString();
            AppData.Instance.customer.Address = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["Street"].ToString();
            AppData.Instance.customer.County = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["County"].ToString();
            AppData.Instance.customer.DOB = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["DateofBirth"].ToString();
            AppData.Instance.customer.PhoneNumber = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["PhoneNumber"].ToString();
            AppData.Instance.customer.Notes = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["CustomerNotes"].ToString();
            AppData.Instance.customer.Town = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["City"].ToString();
            AppData.Instance.customer.State = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["State"].ToString();
            AppData.Instance.customer.ZipCode = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["ZipCode"].ToString();
            AppData.Instance.customer.SpouseFirst = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["SpouseFName"].ToString();
            AppData.Instance.customer.SpouseLast = AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["SpouseLName"].ToString();
            AppData.Instance.customer.CustomerID = Convert.ToInt32(AppData.Instance.customer.dt.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["Customer_ID"].ToString());
            //lbData.Text = AppData.Instance.customer.CustomerID.ToString();
            switch (e.CommandName)
            {
                case "EditPolicies":
                    Response.Redirect("~/WebPages/Policy/SearchPolicies.aspx");
                    break;
                case "EditCustomer":
                    Response.Redirect("~/WebPages/Customer/UpdateCustomer.aspx");
                    break;
                case "EditAlternateContact":
                    Response.Redirect("~/WebPages/AlternateContact/SearchAlternateContact.aspx");
                    break;
                case "EditMedicare":
                    Response.Redirect("~/WebPages/Medicare/UpdateMedicare.aspx");
                    break;
            }
            //AppData.Instance.customer.ID = Convert.ToInt32(e.CommandArgument.ToString());
            //Response.Redirect("~/WebPages/Customer/UpdateCustomer.aspx");
        }

    }
}