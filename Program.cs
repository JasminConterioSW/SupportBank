using System;
using System.Collections.Generic;
using System.IO;


namespace SupportBank
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Bank banker = new Bank();
            banker.ParsedTransactions = Bank.LoadAllTransactionsFromCsv(@"C:\Work\Training\SupportBank\SupportBank\Transactions2014.csv");
            banker.AllAccounts = Account.PopulateNewAccountDictionary(banker.ParsedTransactions);
            
            // List All
            Bank.PrintAllAccountBalances(banker.AllAccounts);
            
            // List Account
            
            

        }
    }
}

