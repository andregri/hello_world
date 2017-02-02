using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ULS;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //items
        Item book1;
        Item book2;
        Item np1;
        Item np2;

        //costumers
        Costumer s;
        Costumer p;
        Costumer e;

        [TestInitialize]
        public void Initialize()
        {
            book1 = new Book("1654654", 1, "Dante Alighieri", "Divina Commedia");
            book2 = new Book("6486768", 5, "Alessandro Manzoni", "Promessi Sposi");
            np1 = new NewsPaper("654684", 10, "Repubblica", DateTime.Today);
            np2 = new NewsPaper("6548448", 10, "Corriere della sera", DateTime.Today.AddDays(-1));

            s = new Student("Alberto Rossi", new DateTime(1996, 1, 1), "a.r@mail.com", "s458454");
            p = new Professor("Walter Verdi", new DateTime(1960, 1, 3), "w.v@uni.com", "p548468");
            e = new ExternalCostumer("Marco Bianchi", new DateTime(1980, 8, 4), "m.b@hmail.com");
            ((ExternalCostumer)e).HasPaidFee = true;
        }

        [TestMethod]
        public void TestBorrowPrintedItem()
        {
            s.Borrow(book1, false);
            Assert.AreEqual(0, book1.Copies);
            Assert.AreEqual(1, s.PrintedItems.Count);
        }

        [TestMethod]
        public void TestBorrowOnlineItem()
        {
            s.Borrow(book1, true);
            Assert.AreEqual(1, book1.Copies);
            Assert.AreEqual(1, s.OnlineItems.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(SoldOutException))]
        public void TestSoldOutException()
        {
            s.Borrow(book1, false);
            p.Borrow(book1, false);
        }

        [TestMethod]
        [ExpectedException(typeof(LimitException))]
        public void TestStudentLimitException()
        {
            for (int i = 0; i < 4; i++)
            {
                s.Borrow(np1, false);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(LimitException))]
        public void TestProfessorLimitException()
        {
            for (int i = 0; i < 9; i++)
            {
                s.Borrow(np1, false);
            }

            for (int i = 0; i < 3; i++)
            {
                s.Borrow(np2, false);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(NotPaidFeeException))]
        public void TestNotPaidFeeException()
        {
            ((ExternalCostumer)e).HasPaidFee = false;
            e.Borrow(book1, false);
        }
    }
}

