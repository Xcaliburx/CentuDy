using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Factory
{
    public class MedicineFactory
    {
        public static Medicine createObject(string Name, string Description, string Stock, string price)
        {
            Medicine medicines = new Medicine();
            medicines.Name = Name;
            medicines.Description = Description;
            medicines.Stock = Stock;
            medicines.Price = price;
            return medicines;
        }

        public static Cart addCart(int userId, int medicineId, string quantity)
        {
            Cart cart = new Cart();
            cart.UserId = userId;
            cart.MedicineId = medicineId;
            cart.Quantity = int.Parse(quantity);
            return cart;
        }
    }
}