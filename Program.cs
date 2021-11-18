using System;
using System.Collections.Generic;
using System.IO;


namespace SupportBank
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Transaction> parsedTransactions =
                Bank.LoadAllTransactionsFromCsv(@"C:\Work\Training\SupportBank\SupportBank\Transactions2014.csv");

            List<string> uniqueNames = Account.GetNames(parsedTransactions);

            foreach (var n in uniqueNames)
            {
                Console.WriteLine(n);
            }

        }
    }
}

