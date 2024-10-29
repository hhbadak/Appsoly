using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class createExpenses : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_expensesSource.DataTextField = "Name";
            ddl_expensesSource.DataValueField = "ID";
            ddl_expensesSource.DataSource = dm.ExpenseSourceList();
            ddl_expensesSource.DataBind();
        }

        protected void lbtn_create_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ddl_expensesSource.SelectedItem.Value) != 0)
            {
                Expenses es = new Expenses();
                es.ExpenseSourceID = Convert.ToInt32(ddl_expensesSource.SelectedItem.Value);
                es.OutGoingFee = Convert.ToDecimal(tb_incomeFee.Text);
                es.Description = tb_description.Text;
                es.Date = DateTime.Now;
                if (dm.CreateExpense(es))
                {
                    string script = "alert('TEBRİKLER Borç ekleme işlemini tamamladınız');";
                    ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                    Response.Redirect("../BDKPanel/expenses.aspx");
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