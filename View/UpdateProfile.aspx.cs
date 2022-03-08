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
    public partial class UpdateProfile : System.Web.UI.Page
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
                txtName.Text = user.Name;
                genderDdl.SelectedValue = user.Gender;
                txtPhone.Text = user.PhoneNumber;
                txtAddress.Text = user.Address;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            user = (User)Session["user"];

            string name = txtName.Text;
            string gender = genderDdl.SelectedValue;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            int userId = user.UserId;

            msgLbl.Text = UserController.UpdateProfile(name, gender, phone, address, userId);

            if(msgLbl.Text.Equals("Successfully Update"))
            {
                Response.Redirect("~/View/ViewProfile.aspx");
            }

        }
    }
}