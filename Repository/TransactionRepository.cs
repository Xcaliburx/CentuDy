using ProjectFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Repository
{
    public class TransactionRepository
    {
        static CentuDYEntities db = new CentuDYEntities();
        public static int CreateHeaderTransaction(HeaderTransaction header)
        {
            db.HeaderTransactions.Add(header);
            db.SaveChanges();
            return header.TransactionId;
        }

        public static bool CreateDetailTransaction(DetailTransaction detail)
        {
            db.DetailTransactions.Add(detail);
            db.SaveChanges();
            return true;
        }
    }
}