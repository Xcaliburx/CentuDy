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
    public partial class ViewCart : System.Web.UI.Page
    {
        List<Cart> cartList = MedicineHandler.ViewAllCart();
        static User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("~/View/LoginPage.aspx");
                }

                user = (User)Session["user"];

                if (user.RoleId == 1)
                {
                    Response.Redirect("~/View/HomePage.aspx");
                }

                if(cartList.Count() == 0)
                {
                    tesLabel.Text = "There is no item in cart";
                }

                CartData.DataSource = cartList;
                CartData.DataBind();
                
                var total = 0;
                foreach(Cart cart in cartList)
                {
                    total += int.Parse(cart.Medicine.Price) * cart.Quantity;
                }
                subtotal.Text = total.ToString();
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.CommandArgument);
            MedicineHandler.deleteCart(id);
            Response.Redirect("/View/ViewCart.aspx");
        }

        protected void Checkout_Click(object sender, EventArgs e)
        {
            if(cartList.Count() == 0)
            {
                DateTime date = DateTime.Now;
                int num = TransactionHandler.CreateHeaderTransaction(user.UserId, date);
                tesLabel.Text = num.ToString();
                foreach (Cart cart in cartList)
                {
                    TransactionHandler.CreateDetailTransaction(num, cart.MedicineId, cart.Quantity);
                }
                MedicineHandler.deleteAllCart();
                Response.Redirect("/View/ViewCart.aspx");
            }
        }
    }
}