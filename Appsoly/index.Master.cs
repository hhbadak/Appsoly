using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly
{
    public partial class index : System.Web.UI.MasterPage
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_subscribeCreate_Click(object sender, EventArgs e)
        {
            // Debug için TextBox'ları kontrol et
            string email = tb_subscribeMail.Text;

            if (string.IsNullOrEmpty(email))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Lütfen mail adresi giriniz!');", true);
                return;
            }

            if (dm.SubscribeDataControl(tb_subscribeMail.Text.Trim()))
            {
                Subscription s = new Subscription
                {
                    EMail = tb_subscribeMail.Text,
                };

                if (dm.CreateSubscribe(s))
                {
                    tb_subscribeMail.Text = "";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Abone olduğunuz için teşekkür ederiz :)');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Lütfen tekrar deneyiniz.');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Aynı Mail yalnızca bir kez eklenebilir!');", true);
            }
        }
    }
}