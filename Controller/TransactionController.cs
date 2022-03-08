using ProjectFinal.Dataset;
using ProjectFinal.Handler;
using ProjectFinal.Model;
using ProjectFinal.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectFinal.Controller
{
    public class TransactionController
    {
        static CentuDYEntities db = new CentuDYEntities();
        private static TransactionData populateData(int id)
        {
            TransactionData transaction = new TransactionData();
            User user = UserHandler.findUserbyId(id);
            var headerTransaction = transaction.HeaderTransaction;
            var headerUser = transaction.User;
            var detailTransaction = transaction.DetailTransaction;
            var detailMedicine = transaction.Medicine;

            var hrowUser = headerUser.NewRow();
            hrowUser["UserId"] = user.UserId;
            hrowUser["Name"] = user.Name;
            hrowUser["Address"] = user.Address;
            hrowUser["PhoneNumber"] = user.PhoneNumber;
            headerUser.Rows.Add(hrowUser);

            foreach(HeaderTransaction h in user.HeaderTransactions)
            {
                var hrow = headerTransaction.NewRow();
                hrow["TransactionId"] = h.TransactionId;
                hrow["UserId"] = h.UserId;
                hrow["TransactionDate"] = h.TransactionDate;
                headerTransaction.Rows.Add(hrow);

                foreach(DetailTransaction d in h.DetailTransactions)
                {
                    var drow = detailTransaction.NewRow();
                    drow["TransactionId"] = d.TransactionId;
                    drow["MedicineId"] = d.MedicineId;
                    drow["Quantity"] = d.Quantity;
                    detailTransaction.Rows.Add(drow);

                    var mrow = detailMedicine.NewRow();
                    mrow["MedicineId"] = d.Medicine.MedicineId;
                    mrow["Name"] = d.Medicine.Name;
                    mrow["Price"] = d.Medicine.Price;
                    detailMedicine.Rows.Add(mrow);
                }
            }
            return transaction;
        }

        public static TransactionReport report(int id)
        {
            TransactionReport reports = new TransactionReport();
            reports.SetDataSource(populateData(id));
            return reports;
        }

        private static TransactionData populateAllData()
        {
            TransactionData transaction = new TransactionData();
            List<User> userList = UserHandler.GetAllUsers();
            var headerTransaction = transaction.HeaderTransaction;
            var headerUser = transaction.User;
            var detailTransaction = transaction.DetailTransaction;
            var detailMedicine = transaction.Medicine;
            int count = (from x in db.DetailTransactions select x).Count();

            foreach(User z in userList)
            {
                var hrowUser = headerUser.NewRow();
                hrowUser["UserId"] = z.UserId;
                hrowUser["Name"] = z.Name;
                hrowUser["Address"] = z.Address;
                hrowUser["PhoneNumber"] = z.PhoneNumber;
                headerUser.Rows.Add(hrowUser);
                foreach (HeaderTransaction h in user.HeaderTransactions)
                {
                    var hrow = headerTransaction.NewRow();
                    hrow["TransactionId"] = h.TransactionId;
                    hrow["UserId"] = h.UserId;
                    hrow["TransactionDate"] = h.TransactionDate;
                    headerTransaction.Rows.Add(hrow);

                    foreach (DetailTransaction d in h.DetailTransactions)
                    {
                        var drow = detailTransaction.NewRow();
                        drow["TransactionId"] = d.TransactionId;
                        drow["MedicineId"] = d.MedicineId;
                        drow["Quantity"] = d.Quantity;
                        detailTransaction.Rows.Add(drow);

                        var mrow = detailMedicine.NewRow();
                        mrow["MedicineId"] = d.Medicine.MedicineId;
                        mrow["Name"] = d.Medicine.Name;
                        mrow["Price"] = d.Medicine.Price;
                        detailMedicine.Rows.Add(mrow);
                    }
                }
            }

            return transaction;
        }

        public static TransactionReport ViewReport()
        {
            TransactionReport reports = new TransactionReport();
            reports.SetDataSource(populateAllData());
            return reports;
        }
    }
}