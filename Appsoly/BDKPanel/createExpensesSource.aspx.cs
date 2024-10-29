﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly.BDKPanel
{
    public partial class createExpensesSource : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_create_Click(object sender, EventArgs e)
        {
            ExpenseSource es = new ExpenseSource();
            es.Name = tb_name.Text;
            if (dm.CreateExpenseSource(es))
            {
                string script = "alert('TEBRİKLER Alacaklı ekleme işlemini tamamladınız');";
                ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
                Response.Redirect("../BDKPanel/sindex.aspx");
            }
            else
            {
                string script = "alert('Blog ekleme sırasında bir sorun oluştur, lütfen tekrar deneyiniz.;";
                ScriptManager.RegisterStartupScript(this, GetType(), "GirisHataScript", script, true);
            }
        }
    }
}