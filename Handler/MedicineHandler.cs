using ProjectFinal.Factory;
using ProjectFinal.Model;
using ProjectFinal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Handler
{
    public class MedicineHandler
    {
        public static List<Medicine> GetAllMedicines()
        {
            return MedicineRepository.GetAllMedicines();
        }

        public static List<Medicine> GetMedicineByName(string name)
        {
            return MedicineRepository.GetMedicinebyName(name);

        }

        public static bool insertMedicine(string name, string description, string stock, string price)
        {
            Medicine medicine = MedicineFactory.createObject(name, description, stock, price);
            return MedicineRepository.insert(medicine);
        }

        public static bool updateMedicine(int id, string name, string description, string stock, string price)
        {
            Medicine medicine = MedicineFactory.createObject(name, description, stock, price);
            return MedicineRepository.update(id, medicine);
        }

        public static bool deleteMedicines(int id)
        {
            return MedicineRepository.deleteMedicines(id);
        }

        public static Medicine getMedicineById(int id)
        {
            return MedicineRepository.getMedicinesId(id);
        }

        public static List<Cart> ViewAllCart()
        {
            return MedicineRepository.viewCart();
        }

        public static bool addCart(int userId, int medicineId, string quantity)
        {
            Cart cart = MedicineFactory.addCart(userId, medicineId, quantity);
            return MedicineRepository.addCart(cart);
        }

        public static void deleteCart(int id)
        {
            MedicineRepository.deleteCart(id);
        }

        public static void deleteAllCart()
        {
            MedicineRepository.deleteAllCart();
            return;
        }
    }
}