using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToSoft_GP_Final
{
    public class Budget
    {
        internal decimal BudgetAmount { get; set; }

        //internal List<Categories> BudgetCategories { get; set; }


        public Budget()
        {
        }




        internal void Withraw(Transaction transaction)
        {
            if (transaction.Amount < 0)
            {
                transaction.Amount = 0;
            }
            OverDraft();
            BudgetAmount -= transaction.Amount;
        }



        internal void OverDraft()
        {
            if (BudgetAmount < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ALERT, YOU HAVE OVERDRAFTED YOUR BUDGET PLEASE READJUST YOUR BUDGET TO COMPENSATE");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to accept this message");
                Console.ReadKey(true);

            }
        }

        internal void Add(Transaction transaction)
        {
            if (transaction.Amount < 0)
            {
                transaction.Amount = 0;
            }

            BudgetAmount += transaction.Amount;
        }

        internal void EditBudget(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid Budget Amount");
            }

            BudgetAmount = amount;
        }
    }
}
