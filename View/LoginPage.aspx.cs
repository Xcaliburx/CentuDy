using ProjectFinal.Controller;
using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectFinal.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] != null)
                {
                    Response.Redirect("~/View/HomePage.aspx");
                }

                if (Request.Cookies["userId"] != null)
                {
                    int userId = int.Parse(Request.Cookies["userId"].Value);

                    User user = UserController.findUserById(userId);

                    usernameTxt.Text = user.Username;
                    passwordTxt.Attributes["value"] = user.Password;

                }
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {

            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            User user = UserController.Login(username, password);

            if(user != null)
            {
                if (rememberMe.Checked)
                {
                    HttpCookie cookie = new HttpCookie("userId");
                    cookie.Value = user.UserId.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }

                Session["user"] = user;
                Response.Redirect("~/View/HomePage.aspx");
            }

            messageLbl.Text = "User with username " + username + " does not exist or password is wrong";

        }
    }
}