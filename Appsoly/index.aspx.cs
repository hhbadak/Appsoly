using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly
{
    public partial class index1 : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Eğer bid parametresi yoksa, parametresiz metodu çağır
                if (string.IsNullOrEmpty(Request.QueryString["bid"]))
                {
                    rp_blog.DataSource = dm.ListBlog(); // Parametresiz metot
                    rp_blog.DataBind();
                }
                else
                {
                    // bid parametresi varsa, parametreli metodu çağır
                    int id = Convert.ToInt32(Request.QueryString["bid"]);
                    rp_blog.DataSource = dm.ListBlog(id); // Parametreli metot
                    rp_blog.DataBind();
                }
                rp_customerLogo.DataSource = dm.ListCustomer();
                rp_customerLogo.DataBind();
            }
        }
    }
}