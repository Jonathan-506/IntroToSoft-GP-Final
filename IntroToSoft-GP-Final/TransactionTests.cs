using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace IntroToSoft_GP_Final
{
 

    public class TransactionTests
    {
        List<Transaction> transactions;

        [SetUp]
        public void Setup()
        {
            transactions = new List<Transaction>();
        }

        [Test]
        public void CreateTransaction()
        {
            Transaction t = new(40, "Groceries", "Walmart");
            transactions.Add(t);
            Assert.That(transactions.Count, Is.EqualTo(1));
        }

        [Test]
        public void DeleteTransaction()
        {
            Transaction t = new(40, "Groceries", "Walmart");
            transactions.Add(t);
            transactions.Remove(t);
            Assert.That(transactions.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestPropertiesOfTransactionClass()
        {
            Transaction t = new(40, "Groceries", "Walmart");
            Assert.That(t.Amount, Is.EqualTo(40));
            Assert.That(t.Category, Is.EqualTo("Groceries"));
            Assert.That(t.Payee, Is.EqualTo("Walmart"));
        }

        [Test]
        public void TestEditTransaction()
        {
            Transaction t = new(40, "Groceries", "Walmart");
            t.Edit(35, "Groceries", "Walmart");
            Assert.That(t.Amount, Is.EqualTo(35));
            Assert.That(t.Category, Is.EqualTo("Groceries"));
            Assert.That(t.Payee, Is.EqualTo("Walmart"));
        }



    }
}
