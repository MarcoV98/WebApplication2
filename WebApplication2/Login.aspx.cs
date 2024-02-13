using System;
using System.Web;

namespace Project1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                if (Request.Cookies["UsernameCookie"] != null)
                {
                    txtUsername.Text = Request.Cookies["UsernameCookie"].Value;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;

            HttpCookie usernameCookie = new HttpCookie("UsernameCookie", username);
            Response.Cookies.Add(usernameCookie);
        }
    }
}