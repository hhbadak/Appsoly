using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly
{
    public partial class blog : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            rp_blogSoftware.DataSource = dm.ListBlogSoftware();
            rp_blogSoftware.DataBind();
            rp_blogSocial.DataSource = dm.ListBlogSocial();
            rp_blogSocial.DataBind();
            rp_blogSeo.DataSource = dm.ListBlogSeo();
            rp_blogSeo.DataBind();
            rp_blogMobile.DataSource = dm.ListBlogMobile();
            rp_blogMobile.DataBind();
            rp_blogBt.DataSource = dm.ListBlogBt();
            rp_blogBt.DataBind();
        }
    }
}