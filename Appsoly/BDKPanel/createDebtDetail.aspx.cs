using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class createDebtDetail : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_debt.DataTextField = "Payee";
            ddl_debt.DataValueField = "ID";
            ddl_debt.DataSource = dm.DebtListFromPayee();
            ddl_debt.DataBind();
        }

        protected void lbtn_create_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ddl_debt.SelectedItem.Value) != 0)
            {
                DebtDetails dd = new DebtDetails();
                dd.DebtID = Convert.ToInt32(ddl_debt.SelectedItem.Value);
                dd.MonthlyPayment = Convert.ToDecimal(tb_monthlyPayment.Text);

                // Seçilen tarihi HiddenField'den çek
                dd.InstallmentDate = Convert.ToDateTime(cal_monthlyPayment.SelectedDate);
                dd.Status = true;

                if (dm.CreateDebtDetail(dd))
                {
                    string script = "alert('TEBRİKLER Borç ekleme işlemini tamamladınız');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                    Response.Redirect("../BDKPanel/debtDetail.aspx");
                }
                else
                {
                    string script = "alert('Blog ekleme sırasında bir sorun oluştur, lütfen tekrar deneyiniz.');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                }
            }
        }


    }
}