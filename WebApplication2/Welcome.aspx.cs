using System;

namespace NomeProgetto
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Request.Cookies["UsernameCookie"] != null)
                {
                    lblLoggedInUsername.Text = Request.Cookies["UsernameCookie"].Value;
                }
                else
                {
                    
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            
            if (Request.Cookies["UsernameCookie"] != null)
            {
                Response.Cookies["UsernameCookie"].Expires = DateTime.Now.AddDays(-1);
            }

            
            Response.Redirect("Login.aspx");
        }
    }
}
