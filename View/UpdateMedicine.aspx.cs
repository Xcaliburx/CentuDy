using ProjectFinal.Factory;
using ProjectFinal.Handler;
using ProjectFinal.Model;
using ProjectFinal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectFinal.View
{
    public partial class UpdateMedicine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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

                int id = int.Parse(Request["MedicineId"]);
                Medicine medicine = MedicineHandler.getMedicineById(id);
                nameTxt.Text = medicine.Name;
                descriptionTxt.Text = medicine.Description;
                numberTxt.Text = medicine.Stock;
                priceTxt.Text = medicine.Price;
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["MedicineId"]);
            string name = nameTxt.Text;
            string description = descriptionTxt.Text;
            string stock = numberTxt.Text;
            string price = priceTxt.Text;
            msgLbl.Text = MedicineController.update(id, name, description, stock, price);
            if (msgLbl.Text.Equals("update success"))
            {
                Response.Redirect("~/View/ViewMedicine.aspx");
            }
        }
    }
}