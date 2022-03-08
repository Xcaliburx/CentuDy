using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Factory
{
    public class TransactionFactory
    {
        public static HeaderTransaction createHeaderTransaction(int userId, DateTime date)
        {
            HeaderTransaction header = new HeaderTransaction();
            header.UserId = userId;
            header.TransactionDate = date;
            return header;
        }

        public static DetailTransaction createDetailTransaction(int transactionId, int medicineId, int quantity)
        {
            DetailTransaction detail = new DetailTransaction();
            detail.TransactionId = transactionId;
            detail.MedicineId = medicineId;
            detail.Quantity = quantity;
            return detail;
        }
    }
}