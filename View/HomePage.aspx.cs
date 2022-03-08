using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectFinal.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["user"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }

                User user = (User)Session["user"];

                if(user.RoleId == 1)
                {
                    cart.Visible = false;
                    history.Visible = false;
                }
                else if(user.RoleId == 2)
                {
                    medicine.Visible = false;
                    users.Visible = false;
                    report.Visible = false;
                }

                LblUser.Text = "Hi, " + user.Username;
            }
        }

        protected void Btnlogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void btnmedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewMedicine.aspx");
        }

        protected void btnprofile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewProfile.aspx");
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewCart.aspx");
        }

        protected void btnhistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewTransactionHistory.aspx");
        }

        protected void btnmedicineins_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertMedicine.aspx");
        }

        protected void btnuser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewUser.aspx");
        }

        protected void btnreport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ViewTransactionReport.aspx");
        }
    }
}