using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class signin : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lbl_email.Text) && !string.IsNullOrEmpty(lbl_password.Text))
            {
                Team t = dm.AdminLogin(lbl_email.Text, lbl_password.Text);
                if (t != null)
                {
                    if (t.Status)
                    {
                        Session["admin"] = t;
                        Response.Redirect("../BDKPanel/sindex.aspx");
                    }
                    else
                    {
                        //pnl_hata.Visible = true;
                        //lbl_hata.Text = "Kullanıcı Hesabınız Aktif değil";
                    }
                }
                else
                {
                    //pnl_hata.Visible = true;
                    //lbl_hata.Text = "Kullanıcı Bulunamadı";
                }
            }
            else
            {
                //pnl_hata.Visible = true;
                //lbl_hata.Text = "Kullanıcı Adı ve Şifre Boş olamaz";
            }
        }
    }
}