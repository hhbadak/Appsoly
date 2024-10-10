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
    public partial class createCustomer : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_create_Click(object sender, EventArgs e)
        {
            if (tb_city != null)
            {
                if (tb_company != null)
                {
                    if (tb_companyPosition != null)
                    {
                        if (tb_mail != null)
                        {
                            if (tb_name != null)
                            {
                                if (tb_phone != null)
                                {

                                    Customers c = new Customers();
                                    c.City = tb_city.Text;
                                    c.Company = tb_company.Text;
                                    c.CompanyPosition = tb_companyPosition.Text;
                                    c.Mail = tb_mail.Text;
                                    c.Name = tb_name.Text;
                                    c.Phone = tb_phone.Text;
                                    c.CreateDate = DateTime.Now;
                                    c.Status = true;
                                    if (fu_image.HasFile)
                                    {
                                        FileInfo fi = new FileInfo(fu_image.FileName);
                                        if (fi.Extension == ".jpg" || fi.Extension == ".png" || fi.Extension == ".jpeg" || fi.Extension == ".JPG" || fi.Extension == ".svg")
                                        {
                                            string uzanti = fi.Extension;
                                            string isim = Guid.NewGuid().ToString();
                                            c.Image = isim + uzanti;
                                            fu_image.SaveAs(Server.MapPath("../assets/images/customer/" + isim + uzanti));
                                        }
                                        else
                                        {
                                            string script = "alert('Resim Uzantısı Yalnızca jpg,jpeg,svg veya png olabilir');";
                                            ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                                        }
                                    }
                                    else
                                    {
                                        c.Image = "none.png";
                                    }

                                    if (dm.CreateCustomer(c))
                                    {
                                        string script = "alert('TEBRİKLER Ürün ekleme işlemini tamamladınız');";
                                        ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                                        Response.Redirect("../BDKPanel/sindex.aspx");
                                    }
                                }
                            }
                            else
                            {
                                string script = "alert('Telefon Numarası alanı boş olamaz');";
                                ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                            }
                        }
                        else
                        {
                            string script = "alert('İsim alanı boş olamaz');";
                            ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                        }
                    }
                    else
                    {
                        string script = "alert('Mail alanı boş olamaz');";
                        ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                    }
                }
                else
                {
                    string script = "alert('Şirket Pozisyonu alanı boş olamaz');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                }
            }
            else
            {
                string script = "alert('Şirket alanı boş olamaz');";
                ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
            }
        }
    }
}