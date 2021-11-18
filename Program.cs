using System;
using System.Collections.Generic;
using System.IO;


namespace SupportBank
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Transaction> parsedTransactions = new List<Transaction>();
            
            // Open file, read in line by line
            using (StreamReader sr = new StreamReader(@"C:\Work\Training\SupportBank\SupportBank\Transactions2014.csv"))
            {
                string data;
                string header = sr.ReadLine();

                while ((data = sr.ReadLine()) != null)
                {
                    parsedTransactions.Add(Transaction.ParseLineCsv(data));
                }
                
            }
        }
    }
}

