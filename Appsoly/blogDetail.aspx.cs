using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly
{
    public partial class blogDetail : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            // bid parametresi varsa, parametreli metodu çağır
            int id = Convert.ToInt32(Request.QueryString["mid"]);
            rp_blogDetail.DataSource = dm.ListBlogDetail(id); // Parametreli metot
            rp_blogDetail.DataBind();
        }
    }
}