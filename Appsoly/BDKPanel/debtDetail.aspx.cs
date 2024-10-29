using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class debtDetail : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        private int detailID; // Class-level variable to hold the ID

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["detailID"] != null)
            {
                detailID = Convert.ToInt32(Request.QueryString["detailID"]);
            }

            if (!IsPostBack)
            {
                if (Request.QueryString["detailID"] != null)
                {
                    lv_debts.DataSource = dm.DebtDeatilListFromID(detailID);
                    lv_debts.DataBind();
                }
            }
        }

        protected void lv_debts_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.DeleteDebtDetail(id);
                Response.Redirect("~/BDKPanel/debtDetail.aspx?detailID=" + detailID.ToString());
            }
            if (e.CommandName == "toggleStatus")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dm.UpdateDebtDetail(id);
                Response.Redirect("~/BDKPanel/debtDetail.aspx?detailID=" + detailID.ToString());
            }
        }

    }
}