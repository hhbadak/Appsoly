using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class createBlog : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_service.DataTextField = "Service";
            ddl_service.DataValueField = "ID";
            ddl_service.DataSource = dm.ServiceList();
            ddl_service.DataBind();

            ddl_team.DataTextField = "Username";
            ddl_team.DataValueField = "ID";
            ddl_team.DataSource = dm.TeamList();
            ddl_team.DataBind();
        }

        protected void lbtn_create_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ddl_service.SelectedItem.Value) != 0)
            {
                Blog b = new Blog();
                b.Title = tb_title.Text;
                b.Brief = tb_brief.Text;
                if (fu_imgThumb.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_imgThumb.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png" || fi.Extension == ".jpeg" || fi.Extension == ".JPG" || fi.Extension == ".svg")
                    {
                        string uzanti = fi.Extension;
                        string isim = Guid.NewGuid().ToString();
                        b.ImgThumb = isim + uzanti;
                        fu_imgThumb.SaveAs(Server.MapPath("../assets/images/blog/imgThumb/" + isim + uzanti));
                    }
                    else
                    {
                        string script = "alert('Resim Uzantısı Yalnızca jpg,jpeg veya png olabilir');";
                        ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                    }
                }
                else
                {
                    b.ImgThumb = "none.png";
                }
                if (fu_image1.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_image1.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png" || fi.Extension == ".jpeg" || fi.Extension == ".JPG" || fi.Extension == ".svg")
                    {
                        string uzanti = fi.Extension;
                        string isim = Guid.NewGuid().ToString();
                        b.Image1 = isim + uzanti;
                        fu_image1.SaveAs(Server.MapPath("../assets/images/blog/images/" + isim + uzanti));
                    }
                    else
                    {
                        string script = "alert('Resim Uzantısı Yalnızca jpg,jpeg veya png olabilir');";
                        ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                    }
                }
                else
                {
                    b.ImgThumb = "none.png";
                }
                b.Contents1 = tb_content1.Text;
                b.Contents2 = tb_content2.Text;
                if (fu_image2.HasFile)
                {
                    FileInfo fi = new FileInfo(fu_image2.FileName);
                    if (fi.Extension == ".jpg" || fi.Extension == ".png" || fi.Extension == ".jpeg" || fi.Extension == ".JPG" || fi.Extension == ".svg")
                    {
                        string uzanti = fi.Extension;
                        string isim = Guid.NewGuid().ToString();
                        b.Image2 = isim + uzanti;
                        fu_image2.SaveAs(Server.MapPath("../assets/images/blog/images/" + isim + uzanti));
                    }
                    else
                    {
                        string script = "alert('Resim Uzantısı Yalnızca jpg,jpeg veya png olabilir');";
                        ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                    }
                }
                else
                {
                    b.ImgThumb = "none.png";
                }
                b.ImportantInformation = tb_importantInformation.Text;
                b.Content2Continued = tb_content2Continued.Text;
                b.Weld = tb_weld.Text;
                b.ServiceID = Convert.ToInt32(ddl_service.SelectedItem.Value);
                b.TeamID = Convert.ToInt32(ddl_team.SelectedItem.Value);
                b.Date = DateTime.Now;
                if (dm.CreateBlog(b))
                {
                    string script = "alert('TEBRİKLER Ürün ekleme işlemini tamamladınız');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                    Response.Redirect("../BDKPanel/sindex.aspx");
                }
                else
                {
                    string script = "alert('Blog ekleme sırasında bir sorun oluştur, lütfen tekrar deneyiniz.;";
                    ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                }
            }
            else
            {
                string script = "alert('Servislerimiz Seçimi Yapmalısın');";
                ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
            }
        }
    }
}