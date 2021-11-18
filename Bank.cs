using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace SupportBank
{
    public class Bank
    {
        public List<Transaction> ParsedTransactions;
        public Dictionary<string, Account> AllAccounts;
        
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
            
            /*// Print out all transactions
            foreach (var t in parsedTransactions)
            {
                Transaction.PrintTransaction(t);
            }
            */

            return parsedTransactions;
        }

        

        public static void PrintAllAccountBalances(Dictionary<string,Account> allAccounts)
        { 
            foreach (KeyValuePair<string,Account> acc in allAccounts)
            {
                Account.PrintAccountBalance(acc.Value);
            }
        }

        public static void PrintAccountTransactions(Account account)
        {
            List<Transaction> accountTransactions = account.AccountTransactions;
            foreach (Transaction t in accountTransactions)
            {
                Transaction.PrintTransaction(t);
            }
        }
    }
}