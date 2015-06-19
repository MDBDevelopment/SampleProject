using BO;
using DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace DAL
{
    public class CsvTransactionsRepository : ITransactionsRepository
    {
        private readonly string _file;

        public CsvTransactionsRepository(string file)
        {
            _file = file;
        }

        public IEnumerable<Transaction> GetTransactions(int userId)
        {
            string userFile = string.Format(_file, userId);

            using (TextReader reader = File.OpenText(userFile))
            {
                var csv = new CsvReader(reader);

                return csv.GetRecords<Transaction>().ToList();
            }
        }
    }
}
