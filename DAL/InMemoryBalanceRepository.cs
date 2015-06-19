using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InMemoryBalanceRepository
    {
        private static InMemoryBalanceRepository instance;

        public static InMemoryBalanceRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InMemoryBalanceRepository();
                }
                return instance;
            }
        }

        public decimal GetBalance(int userId) {
            if (userId != 1)
                throw new Exception("User does not exist");

            return 200M;
        }
    }
}
