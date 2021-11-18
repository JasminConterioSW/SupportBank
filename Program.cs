using System;
using System.Collections.Generic;
using System.IO;

namespace SupportBank
{
    
  class Transaction
    {
        public string date;
        public string nameFrom;
        public string nameTo;
        public string narrative;
        public decimal amount;
        
    }
    
    class Program
    {
        private List<Transaction> parsedTransactions;


        private static void ParseLine(string data)
        {
            string[] dataFields = data.Split(',');

            Transaction currentTransaction = new Transaction();
            currentTransaction.date = dataFields[0];
            currentTransaction.nameFrom = dataFields[1];
            currentTransaction.nameTo = dataFields[2];
            currentTransaction.narrative = dataFields[3];
            currentTransaction.amount = Convert.ToDecimal(dataFields[4]);


            Console.WriteLine(currentTransaction.amount);
        }
        
        static void Main(string[] args)
        {
            
            
            // Open file, read in line by line
            using (StreamReader sr = new StreamReader(@"C:\Work\Training\SupportBank\SupportBank\Transactions2014.csv"))
            {
                string data;
                string header = sr.ReadLine();

                while ((data = sr.ReadLine()) != null)
                {
                    ParseLine(data);
                }
                
                

            }
                
            
            
            
        }
    }

    
    
    
}

