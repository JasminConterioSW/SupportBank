using System;

namespace SupportBank
{
    public class Transaction
    {
        public string Date;
        public string NameFrom;
        public string NameTo;
        public string Narrative;
        public decimal Amount;
        
        public static Transaction ParseLineCsv(string data)
        {
            string[] dataFields = data.Split(',');

            Transaction currentTransaction = new Transaction();
            currentTransaction.Date = dataFields[0];
            currentTransaction.NameFrom = dataFields[1];
            currentTransaction.NameTo = dataFields[2];
            currentTransaction.Narrative = dataFields[3];
            currentTransaction.Amount = Convert.ToDecimal(dataFields[4]);

            return currentTransaction;
        }

        public static void PrintTransaction(Transaction currentTransaction)
        {
            string outputString =
                $"{currentTransaction.Date}: From {currentTransaction.NameFrom} to {currentTransaction.NameTo}, {currentTransaction.Narrative}, £{currentTransaction.Amount}";
            Console.WriteLine(outputString);
        }
        
    }
}