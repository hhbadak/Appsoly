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

            rp_comment.DataSource = dm.ListComment(id); // Parametreli metot
            rp_comment.DataBind();
        }

        protected void lbtn_submit_Click(object sender, EventArgs e)
        {
            // Debug için TextBox'ları kontrol et
            string name = tb_name.Text;
            string email = tb_mail.Text;
            string comment = tb_comment.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(comment))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Boş alan bırakmayınız!');", true);
                return;
            }

            int id = Convert.ToInt32(Request.QueryString["mid"]);
            if (dm.DataControl(tb_comment.Text.Trim()))
            {
                BlogComment bc = new BlogComment
                {
                    BlogID = id,
                    Name = tb_name.Text,
                    EMail = tb_mail.Text,
                    Comment = tb_comment.Text,
                    Date = DateTime.Now
                };

                if (dm.CreateComment(bc))
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "notification",
    "document.getElementById('" + tb_comment.ClientID + "').value=''; " +
    "document.getElementById('" + tb_mail.ClientID + "').value=''; " +
    "document.getElementById('" + tb_name.ClientID + "').value=''; " +
    "location.reload();", true);

                }

                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Lütfen tekrar deneyiniz.');", true);
                }
            }
            else
            {
                tb_comment.Text = " ";
                tb_mail.Text = " ";
                tb_name.Text = " ";
            }
        }
    }
}