using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class expenses : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_expenses.DataSource = dm.ExpenseListFromPayee();
            lv_expenses.DataBind();
        }

        protected void lv_expenses_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.DeleteDebt(id);
                Response.Redirect("~/BDKPanel/expenses.aspx");
            }
        }
    }
}