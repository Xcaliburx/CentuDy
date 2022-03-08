using ProjectFinal.Factory;
using ProjectFinal.Model;
using ProjectFinal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Handler
{
    public class TransactionHandler
    {
        public static int CreateHeaderTransaction(int userId, DateTime date)
        {
            HeaderTransaction headerTransaction = TransactionFactory.createHeaderTransaction(userId, date);
            return TransactionRepository.CreateHeaderTransaction(headerTransaction);
        }

        public static bool CreateDetailTransaction(int transactionId, int medicineId, int quantity)
        {
            DetailTransaction detailTransaction = TransactionFactory.createDetailTransaction(transactionId, medicineId, quantity);
            return TransactionRepository.CreateDetailTransaction(detailTransaction);
        }
    }
}