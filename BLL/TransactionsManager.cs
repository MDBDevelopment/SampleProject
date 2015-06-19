using BLL.Abstract;
using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransactionsManager : ITransactionsManager
    {
        public readonly string _csv;

        public TransactionsManager(string csv)
        {
            _csv = csv;
        }

        public IEnumerable<Transaction> GetTransactions(int userId)
        {
            var db = new CsvTransactionsRepository(_csv);

            return db.GetTransactions(userId);
        }
    }
}
