using ProjectFinal.Factory;
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
    public partial class AddCart : System.Web.UI.Page
    {
        static Medicine medicine;
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

                int id = int.Parse(Request["MedicineId"]);
                medicine = MedicineHandler.getMedicineById(id);
                nametxt.Text = medicine.Name;
                descriptiontxt.Text = medicine.Description;
                stocktxt.Text = medicine.Stock;
                pricetxt.Text = medicine.Price;
            }
        }

        protected void sumbit_Click(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            int userId = user.UserId;
            int stock = int.Parse(medicine.Stock);
            int medicineId = medicine.MedicineId;
            string quantity = quantityTxt.Text;
            msgLbl.Text = MedicineController.addCart(userId, stock, medicineId, quantity);
            if (msgLbl.Text.Equals("success"))
            {
                Response.Redirect("~/View/ViewCart.aspx");
            }
        }
    }
}