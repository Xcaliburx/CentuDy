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
    public partial class ViewTransactionHistory : System.Web.UI.Page
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

                if (user.RoleId == 1)
                {
                    Response.Redirect("~/View/HomePage.aspx");
                }

                int userId = user.UserId;

                TransactionHistory.ReportSource = TransactionController.report(userId);
            }
        }
    }
}