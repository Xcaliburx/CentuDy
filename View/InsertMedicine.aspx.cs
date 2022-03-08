using ProjectFinal.Factory;
using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectFinal.View
{
    public partial class InsertMedicine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }

            User user = (User)Session["user"];

            if (user.RoleId == 2)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string description = descriptionTxt.Text;
            string stock = numberTxt.Text;
            string price = priceTxt.Text;
            msgLbl.Text = MedicineController.insert(name, description, stock, price);
            if (msgLbl.Text.Equals("insert success"))
            {
                Response.Redirect("~/View/ViewMedicine.aspx");
            }
        }
    }
}