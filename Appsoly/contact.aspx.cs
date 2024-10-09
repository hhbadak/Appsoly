using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Appsoly
{
    public partial class contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_send_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text.Trim();
            string email = tb_mail.Text.Trim();
            string subject = tb_subject.Text.Trim();
            string description = tb_description.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(description))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Lütfen tüm alanları doldurun.');", true);
                return;
            }

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("neptune.odeaweb.com", 587); // SMTP sunucusu ve port
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("info@appsoly.com", "yP9a00@f1");
                smtp.Timeout = 120000; // Timeout'u artırdık

                mail.From = new MailAddress("info@appsoly.com");
                mail.To.Add("info@appsoly.com");
                mail.Subject = $"İletişim Formu - {subject}";
                mail.Body = $"Adı: {name}\nE-posta: {email}\nKonu: {subject}\nMesaj: {description}";
                mail.IsBodyHtml = false;

                smtp.Send(mail);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Mesajınız başarıyla gönderildi.');", true);

                tb_name.Text = "";
                tb_mail.Text = "";
                tb_subject.Text = "";
                tb_description.Text = "";
            }
            catch (Exception ex)
            {
                string errorMsg = ex.ToString(); // Daha ayrıntılı hata bilgisi
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('Hata: {errorMsg}');", true);
            }
        }



    }
}