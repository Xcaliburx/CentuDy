using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Repository
{
    public class MedicineRepository
    {
        static CentuDYEntities db = new CentuDYEntities();
        public static List<Medicine> GetAllMedicines()
        {
            var query = (from x
                         in db.Medicines
                         select x);

            List<Medicine> medicineList = query.ToList();

            return medicineList;
        }

        public static List<Medicine> GetMedicinebyName(string name)
        {
            var query = (from x
                         in db.Medicines
                         where x.Name == name
                         select x);

            List<Medicine> medicines = query.ToList();

            return medicines;
        }

        public static bool insert(Medicine medicines)
        {
            db.Medicines.Add(medicines);
            db.SaveChanges();
            return true;
        }

        public static bool update(int id, Medicine newMedicine)
        {
            Medicine medicine = db.Medicines.Find(id);
            medicine.Name = newMedicine.Name;
            medicine.Description = newMedicine.Description;
            medicine.Stock = newMedicine.Stock;
            medicine.Price = newMedicine.Price;
            db.SaveChanges();
            return true;
        }

        public static Medicine getMedicinesId(int id)
        {
            return db.Medicines.Find(id);
        }

        public static bool deleteMedicines(int id)
        {
            Cart cart = (from x in db.Carts where x.MedicineId == id select x).FirstOrDefault();
            DetailTransaction det = (from x in db.DetailTransactions where x.MedicineId == id select x).FirstOrDefault();

            if(cart != null || det != null)
            {
                return false;
            }

            var query = from x in db.Medicines where x.MedicineId == id select x;
            Medicine temp = (query).FirstOrDefault();
            if (temp != null)
            {
                db.Medicines.Remove(temp);
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public static List<Cart> viewCart()
        {
            var query = (from x in db.Carts
                         join y in db.Medicines on x.MedicineId equals y.MedicineId
                         select new { y.Name, y.Price }).ToList();
            return db.Carts.ToList();
        }

        public static bool addCart(Cart cart)
        {
            Medicine medicine = db.Medicines.Find(cart.MedicineId);

            var query = (from x in db.Carts
                         where x.MedicineId == cart.MedicineId
                         select x);
            Cart carts = query.FirstOrDefault();
            
            if(carts == null)
            {
                db.Carts.Add(cart);
            }
            else
            {
                carts.Quantity = carts.Quantity + cart.Quantity;
            }

            medicine.Stock = (Convert.ToInt32(medicine.Stock) - Convert.ToInt32(cart.Quantity)).ToString();
            db.SaveChanges();
            return true;
        }

        public static void deleteCart(int id)
        {
            Medicine medicine = db.Medicines.Find(id);

            var query = from x in db.Carts where x.MedicineId == id select x;
            Cart temp = (query).FirstOrDefault();
            if (temp != null)
            {
                db.Carts.Remove(temp);
                medicine.Stock = (Convert.ToInt32(medicine.Stock) + Convert.ToInt32(temp.Quantity)).ToString();
                db.SaveChanges();
            }
            return;
        }

        public static void deleteAllCart()
        {
            db.Database.ExecuteSqlCommand("DELETE FROM CART");
            db.SaveChanges();
            return;
        }
    }
}