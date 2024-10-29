using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class monthlyPayments : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_monthlyPayment.DataSource = dm.DebtDeatilListFromDate();
            lv_monthlyPayment.DataBind();
        }

        protected void lv_monthlyPayment_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.DeleteDebt(id);
                Response.Redirect("~/BDKPanel/monthlyPayments.aspx");
            }
            if (e.CommandName == "toggleStatus")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.UpdateDebtDetail(id);
                Response.Redirect("~/BDKPanel/monthlyPayments.aspx");
            }
        }
    }
}