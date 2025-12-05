using NUnit.Framework;


namespace IntroToSoft_GP_Final
{


    public class BudgetTests
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]

        public void TestWithdrawMethod()
        {
            Budget budget = new Budget();
            budget.BudgetAmount = 150;

            Transaction transaction = new Transaction(75, "bills", "Electric Co.");

            budget.Withraw(transaction);

            Assert.That(budget.BudgetAmount, Is.EqualTo(75));
        }

        public void TestWithdrawMethodWithNegativeNumber()
        {
            Budget budget = new Budget();
            budget.BudgetAmount = 150;

            Transaction transaction = new Transaction(-125, "bills", "Electric Co.");

            budget.Withraw(transaction);

            Assert.That(budget.BudgetAmount, Is.EqualTo(150));
        }

        public void TestAdditionToBudget()
        {
            Budget budget = new Budget();
            budget.BudgetAmount = 150;

            Transaction transaction = new Transaction(32, "Pay u back", "Mikey");

            budget.Add(transaction);

            Assert.That(budget.BudgetAmount, Is.EqualTo(182));
        }

        public void TestAdditionWithNegativeNumber()
        {
            Budget budget = new Budget();
            budget.BudgetAmount = 516;

            Transaction transaction = new Transaction(-87, "Pay u back", "Mikey");

            budget.Add(transaction);

            Assert.That(budget.BudgetAmount, Is.EqualTo(516));
        }


        public void TestChangeBudgetAmount()
        {
            Budget budget = new Budget();
            budget.BudgetAmount = 1000;

            decimal amount = 1600;

            budget.EditBudget(amount);

            Assert.That(budget.BudgetAmount, Is.EqualTo(amount));

        }
    }
}
