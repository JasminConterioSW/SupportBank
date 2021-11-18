using System;
using System.Collections.Generic;

namespace SupportBank
{
    public class Account
    {
        public string Name;
        public decimal Balance;
        


        
        public static List<string> GetNames(List<Transaction> parsedTransactions)
        {
            List<string> uniqueNames = new List<string>();
            
            foreach (var t in parsedTransactions)
            {
                if (!uniqueNames.Contains(t.NameFrom))
                {
                    uniqueNames.Add(t.NameFrom);
                }

                if (!uniqueNames.Contains(t.NameTo))
                {
                    uniqueNames.Add(t.NameTo);
                }
            }

            return uniqueNames;
        }

        public static Account InitialiseAccount(string accountName)
        {
            Account account = new Account();
            account.Name = accountName;
            account.Balance = 0;
            
            return account;
        }
        
        public static Dictionary<string,Account>  InitialiseAccountDictionary(List<string> accountNames)
        {
            Dictionary<string,Account> accountDict= new Dictionary<string,Account>();

            foreach (var aName in accountNames)
            {
                accountDict.Add(aName,InitialiseAccount(aName));
            }

            return accountDict;

        }
        
        
        public static void PrintAccount(Account acc)
        {
            string outputString = "";
            
            if (acc.Balance < 0)
            {
                outputString = $"{acc.Name}  owes £ {acc.Balance}";
            }
            else
            {
                outputString = $"{acc.Name}  is owed £ {acc.Balance}";
            }

            Console.WriteLine(outputString);
        }

    }
}