using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class payees : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_payees.DataSource = dm.PayeeList();
            lv_payees.DataBind();
        }

        protected void lv_payees_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.DeletePayee(id);
                Response.Redirect("~/BDKPanel/payees.aspx");
            }
        }
    }
}