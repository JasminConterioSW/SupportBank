using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

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
            
            /*// Print out all transactions
            foreach (var t in parsedTransactions)
            {
                Transaction.PrintTransaction(t);
            }
            */

            return parsedTransactions;
        }

        public static Dictionary<string,Account> PopulateNewAccountDictionary(List<Transaction> parsedTransactions)
        {
            // Complete but not properly tested
            List<string> uniqueNames = Account.GetNames(parsedTransactions);
            Dictionary<string,Account> allAccounts = Account.InitialiseAccountDictionary(uniqueNames);
            
            foreach (var t in parsedTransactions)
            {
                string nameTo = t.NameTo;
                string nameFrom = t.NameFrom;
                decimal amount = t.Amount;

                allAccounts[nameTo].Balance += amount;
                allAccounts[nameFrom].Balance -= amount;

            }

            return allAccounts;
        }

        /*public static void PrintAllAccounts(Dictionary<string,Account> allAccounts)
        { // very much incomplete
            foreach (KeyValuePair acc in allAccounts)
            {

                allAccounts.PrintAccount(acc);
            }
        }*/
        
    }
}