using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToSoft_GP_Final
{
    class Transaction
    {
        public decimal Amount;
        public string Category;
        public string Payee;
        public Transaction(int amount, string category, string payee)
        {
            Amount = amount;
            Category = category;
            Payee = payee;
        }

        public void Edit(int amount, string category, string payee)
        {
            Amount = amount;
            Category = category;
            Payee = payee;
        }
    }
}
