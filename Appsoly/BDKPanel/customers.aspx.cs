using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class customers : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_listCustomers.DataSource = dm.ListCustomer();
            lv_listCustomers.DataBind();
        }

        protected void lv_listCustomers_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.DeleteBlog(id);
                Response.Redirect("~/BDKPanel/customers.aspx");
            }
        }
    }
}