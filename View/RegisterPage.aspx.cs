using ProjectFinal.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectFinal.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string confpassword = confPasswordTxt.Text;
            string name = nameTxt.Text;
            string gender = genderDdl.SelectedValue;
            string phoneNumber = phoneTxt.Text;
            string address = addressTxt.Text;

            msgLbl.Text = UserController.Register(username, password, confpassword, name, gender, phoneNumber, address);

            if (msgLbl.Text.Equals("Successfully register"))
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }

        }
    }
}