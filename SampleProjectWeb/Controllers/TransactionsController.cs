using BLL;
using BLL.Abstract;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechnicalTest.Models;

namespace TechnicalTest.Controllers
{
    public class TransactionsController : Controller
    {
        public ActionResult Index()
        {
            string csv = Server.MapPath("~/App_data/data-user{0}.csv");
            ITransactionsManager transactionsManager = new TransactionsManager(csv);
            IBalanceManager balanceManager = new BalanceManager();
            var userId = 1;
            var model = new TransactionsModel {
                Balance = balanceManager.GetBalance(userId),
                TransactionIds = transactionsManager.GetTransactions(userId).Select(t => t.Id) 
            };

            return View(model);
        }

        public ActionResult GetTransaction(int transactionId)
        {
            string csv = Server.MapPath("~/App_data/data-user{0}.csv");
            ITransactionsManager transactionsManager = new TransactionsManager(csv);
            var userId = 1;
            var transaction = transactionsManager.GetTransactions(userId).First(t => t.Id == transactionId);

            return PartialView("TransactionPartial", transaction);
            
        }
    }
}