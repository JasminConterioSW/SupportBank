using System;

namespace SupportBank
{
    public class Transaction
    {
        public static Transaction ParseLineCsv(string data)
        {
            string[] dataFields = data.Split(',');

            Transaction currentTransaction = new Transaction();
            currentTransaction.date = dataFields[0];
            currentTransaction.nameFrom = dataFields[1];
            currentTransaction.nameTo = dataFields[2];
            currentTransaction.narrative = dataFields[3];
            currentTransaction.amount = Convert.ToDecimal(dataFields[4]);

            return currentTransaction;
        }
        
        public string date;
        public string nameFrom;
        public string nameTo;
        public string narrative;
        public decimal amount;
        
    }
}