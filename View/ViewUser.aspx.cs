using ProjectFinal.Handler;
using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectFinal.View
{
    public partial class ViewUser : System.Web.UI.Page
    {
        List<User> userList = UserHandler.GetAllUsers();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }

                User user = (User)Session["user"];

                if (user.RoleId == 2)
                {
                    Response.Redirect("~/View/HomePage.aspx");
                }

                grdUser.DataSource = userList;
                grdUser.DataBind();
            }
        }

        protected void grdUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int toDeleteIdx = e.RowIndex;
            int userId = userList[toDeleteIdx].UserId;

            UserHandler.DeleteUser(userId);

            Response.Redirect("~/View/ViewUser.aspx");
        }
    }
}