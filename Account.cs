using System.Collections.Generic;

namespace SupportBank
{
    public class Account
    {
        public string Name;
        public decimal balance;

        public static Account PopulateAccount(string Name, List<Transaction> parsedTransactions);
        {
            
        }
        
        
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

    }
}