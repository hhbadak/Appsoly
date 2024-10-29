using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class createDebts : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_payee.DataTextField = "Name";
            ddl_payee.DataValueField = "ID";
            ddl_payee.DataSource = dm.PayeeList();
            ddl_payee.DataBind();
        }

        protected void lbtn_create_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ddl_payee.SelectedItem.Value) != 0)
            {
                Debts d = new Debts();
                d.PayeeID = Convert.ToInt32(ddl_payee.SelectedItem.Value);
                d.TotalDebt = Convert.ToDecimal(tb_totalDebt.Text);
                d.MonthlyPayment = Convert.ToDecimal(tb_monthlyPayment.Text);
                d.Statu = true;
                if (dm.CreateDebt(d))
                {
                    string script = "alert('TEBRİKLER Borç ekleme işlemini tamamladınız');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                    Response.Redirect("../BDKPanel/debts.aspx");
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