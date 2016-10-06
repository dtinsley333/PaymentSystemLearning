using System;

namespace ConsoleApplication
{
    public class Payment
    {
        public decimal Amount{get;set;}

        public virtual  string MakePayment()
        {
          return $"You paid ${this.Amount} in Cash ";
        }

        public string SendConfirmation(string email)
        {
           return "You purchased several nice items"; 
        }

        public string SendConfirmation(string email, bool digitalDownload)
        {
           return "Check your email for the downloadable book"; 
        }
    }
}

