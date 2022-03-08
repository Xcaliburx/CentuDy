using ProjectFinal.Handler;
using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Factory
{
    public class MedicineController
    {
        public static string insert(string name, string description, string stock, string price)
        {
            bool validate = true;
            string msg = "";
            if (string.IsNullOrEmpty(name))
            {
                msg += "name cannot be empty \n";
                validate = false;
            }

            if (string.IsNullOrEmpty(description))
            {
                msg += "description cannot be empty \n";
                validate = false;
            }
            else if(description.Length <= 10)
            {
                msg += "description must be longer than 10 character \n";
                validate = false;
            }

            if (string.IsNullOrEmpty(stock)){
                msg += "stock cannot be empty \n";
                validate = false;
            }
            else if (int.Parse(stock) <= 0)
            {
                msg += "stock must be greater 0 \n";
                validate = false;
            }

            if (string.IsNullOrEmpty(price))
            {
                msg += "price cannot be empty \n";
                validate = false;
            }
            else if (int.Parse(price) <= 0)
            {
                msg += "price must be greater 0 \n";
                validate = false;
            }

            if (validate == true)
            {
                bool insertMedicine = MedicineHandler.insertMedicine(name, description, stock, price);
                if(insertMedicine == false)
                {
                    msg = "insert failed";
                    return msg;
                }
                return "insert success";
            }
            return msg;
        }

        public static string update(int id, string name, string description, string stock, string price)
        {
            bool validate = true;
            string msg = "";
            if (string.IsNullOrEmpty(name))
            {
                msg += "name cannot be empty \n";
                validate = false;
            }

            if (string.IsNullOrEmpty(description))
            {
                msg += "description cannot be empty \n";
                validate = false;
            }
            else if (description.Length <= 10)
            {
                msg += "description must be longer than 10 character \n";
                validate = false;
            }

            if (string.IsNullOrEmpty(stock))
            {
                msg += "stock cannot be emty \n";
                validate = false;
            }
            else if (int.Parse(stock) <= 0)
            {
                msg += "stock must be greater 0 \n";
                validate = false;
            }

            if (string.IsNullOrEmpty(price))
            {
                msg += "price cannot be emty \n";
                validate = false;
            }
            else if (int.Parse(price) <= 0)
            {
                msg += "price must be greater 0 \n";
                validate = false;
            }

            if (validate == true)
            {
                bool insertMedicine = MedicineHandler.updateMedicine(id, name, description, stock, price);
                if (insertMedicine == false)
                {
                    msg = "update failed";
                    return msg;
                }
                return "update success";
            }
            return msg;
        }

        public static string addCart(int userId, int stock, int medicineId, string quantity)
        {
            bool validate = true;
            string msg = "";
            if(string.IsNullOrEmpty(quantity))
            {
                msg += "quantity cannot be empty \n";
                validate = false;
            }
            else if(int.Parse(quantity) < 0)
            {
                msg += "quantity must be greater than 0 \n";
                validate = false;
            }
            else if(int.Parse(quantity) > stock)
            {
                msg += "quantity must be less than stock \n";
                validate = false;
            }

            if(validate == true)
            {
                bool addCart = MedicineHandler.addCart(userId, medicineId, quantity);
                if(addCart == false)
                {
                    msg = "failed to add item to cart";
                    return msg;
                }
                return "success";
            }
            return msg;
        }
    }
}