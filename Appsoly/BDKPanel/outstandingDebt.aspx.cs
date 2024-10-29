using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class outstandingDebt : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_outstanding.DataSource = dm.DebtDeatilListFromPayFalse();
            lv_outstanding.DataBind();
        }

        protected void lv_outstanding_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.DeleteDebt(id);
                Response.Redirect("~/BDKPanel/outstandingDebt.aspx");
            }
            if (e.CommandName == "toggleStatus")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.UpdateDebtDetail(id);
                Response.Redirect("~/BDKPanel/outstandingDebt.aspx");
            }
        }
    }
}