using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class sindex : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataModel dm = new DataModel();
            if (Session["admin"] != null)
            {
                Team t = (Team)Session["admin"];
                rp_user.DataSource = dm.TeamList();
                rp_user.DataBind();
                rp_team.DataSource = dm.TeamList();
                rp_team.DataBind();

            }
            else
            {
                Response.Redirect("../BDKPanel/signin.aspx");
            }
        }
    }
}