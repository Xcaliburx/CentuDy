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
    public partial class ChangePassword : System.Web.UI.Page
    {
        User user;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }

                user = (User)Session["user"];

                lblUsername.Text = user.Username;

            }
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            user = (User)Session["user"];

            string oldPass = txtOld.Text;
            string newPass = txtNew.Text;
            string confPass = txtConfirm.Text;
            string currPass = user.Password;
            int userId = user.UserId;

            msglbl.Text = UserController.ChangePassword(oldPass, newPass, confPass, currPass, userId);

        }
    }
}