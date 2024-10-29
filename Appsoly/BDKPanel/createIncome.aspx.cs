using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class createIncome : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_incomeSource.DataTextField = "Name";
            ddl_incomeSource.DataValueField = "ID";
            ddl_incomeSource.DataSource = dm.IncomeSourceList();
            ddl_incomeSource.DataBind();
        }

        protected void lbtn_create_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ddl_incomeSource.SelectedItem.Value) != 0)
            {
                Incomes i = new Incomes();
                i.IncomeSourceID = Convert.ToInt32(ddl_incomeSource.SelectedItem.Value);
                i.IncomingFee = Convert.ToDecimal(tb_incomeFee.Text);
                i.Description = tb_description.Text;
                i.Date = DateTime.Now;
                if (dm.CreateIncome(i))
                {
                    string script = "alert('TEBRİKLER Borç ekleme işlemini tamamladınız');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                    Response.Redirect("../BDKPanel/incomes.aspx");
                }
                else
                {
                    string script = "alert('Blog ekleme sırasında bir sorun oluştur, lütfen tekrar deneyiniz.;";
                    ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                }
            }
        }
    }
}