using System.Collections.Generic;
using System.IO;

namespace SupportBank
{
    public class Bank
    {
        public static List<Transaction> LoadAllTransactionsFromCsv(string filename)
        {
            List<Transaction> parsedTransactions = new List<Transaction>();
            
            // Open file, read in line by line
            using (StreamReader sr = new StreamReader(filename))
            {
                string data;
                string header = sr.ReadLine();

                while ((data = sr.ReadLine()) != null)
                {
                    parsedTransactions.Add(Transaction.ParseLineCsv(data));
                }
                
            }
            
            // Print out all transactions
            foreach (var t in parsedTransactions)
            {
                Transaction.PrintTransaction(t);
            }

            return parsedTransactions;
        }
    }
}