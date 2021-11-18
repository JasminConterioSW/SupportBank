using System;
using System.IO;

namespace SupportBank
{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {

            // Open file, read in line by line
            using (StreamReader sr = new StreamReader(@"C:\Work\Training\SupportBank\SupportBank\Transactions2014.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
                
            
           
            
            
            
        }
    }
}

