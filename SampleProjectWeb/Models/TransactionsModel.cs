using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnicalTest.Models
{
    public class TransactionsModel
    {
        public decimal Balance { get; set; }
        public IEnumerable<int> TransactionIds { get; set; }
    }
}