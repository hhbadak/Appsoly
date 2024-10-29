using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class debts : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_debts.DataSource = dm.DebtListFromPayee();
            lv_debts.DataBind();
        }

        protected void lv_debts_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.DeleteDebt(id);
                Response.Redirect("~/BDKPanel/debts.aspx");
            }
            if (e.CommandName == "debtDetail")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.DebtDeatilListFromID(id);
                Response.Redirect("~/BDKPanel/debts.aspx");
            }
        }
    }
}