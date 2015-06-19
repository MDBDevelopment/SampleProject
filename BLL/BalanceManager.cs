using BLL.Abstract;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BalanceManager : IBalanceManager
    {
        public decimal GetBalance(int userId)
        {
            return InMemoryBalanceRepository.Instance.GetBalance(userId);
        }
    }
}
