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
    public partial class ViewMedicine : System.Web.UI.Page
    {
        static List<Medicine> medicineList;
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
                    medicinesData.Columns[2].Visible = false;
                }
                else if (user.RoleId == 2)
                {
                    medicinesData.Columns[0].Visible = false;
                    medicinesData.Columns[1].Visible = false;
                    insert.Visible = false;
                }

                if (Request["MedicineName"] != null)
                {
                    string name = Request["MedicineName"];
                    medicineList = MedicineHandler.GetMedicineByName(name);

                    if (string.IsNullOrEmpty(name))
                    {
                        medicineList = MedicineHandler.GetAllMedicines();
                    }
                }
                else
                {
                    medicineList = MedicineHandler.GetAllMedicines();
                }

                medicinesData.DataSource = medicineList;
                medicinesData.DataBind();
            }
        }

        protected void medicinesData_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = int.Parse(e.CommandArgument.ToString());
            Medicine medicine = medicineList.ElementAt(index);
            if (e.CommandName == "update")
            {
                Response.Redirect("/View/UpdateMedicine.aspx?MedicineId=" + medicine.MedicineId);
            }
            if (e.CommandName == "delete")
            {
                int id = medicine.MedicineId;
                bool check = MedicineHandler.deleteMedicines(id);
                if(check == false)
                {
                    Response.Redirect("/View/ViewMedicine.aspx");
                }
                else
                {
                    Response.Redirect("/View/ViewMedicine.aspx");
                }
            }
            if (e.CommandName == "addCart")
            {
                Response.Redirect("/View/AddCart.aspx?MedicineId=" + medicine.MedicineId);
            }
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            string name = searchTxt.Text;
            Response.Redirect("/View/ViewMedicine.aspx?MedicineName=" + name);
        }
    }
}