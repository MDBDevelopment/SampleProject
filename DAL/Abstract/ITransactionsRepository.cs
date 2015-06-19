using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface ITransactionsRepository
    {
        IEnumerable<Transaction> GetTransactions(int userId);
    }
}
