using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectFinal.View
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }

                User user = (User)Session["user"];

                lblUsername.Text = user.Username;
                lblName.Text = user.Name;
                lblGender.Text = user.Gender;
                lblPhone.Text = user.PhoneNumber;
                lblAddress.Text = user.Address;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdateProfile.aspx");
        }

        protected void btnchange_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ChangePassword.aspx");
        }
    }
}