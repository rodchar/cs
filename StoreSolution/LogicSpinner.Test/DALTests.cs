using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LogicSpinner.Test
{
    [TestFixture]
    public class DALTests
    {


        [SetUp]
        protected void SetUp()
        {

        }

        [TearDown]
        protected void TearDown()
        {

        }

        [Test]
        public void GetProducts()
        {
            List<Product> p = ProductDAL.Products();

            Assert.Greater(p.Count, 0);
        }


        [Test]
        public void GetRewards()
        {
            List<Reward> r = RewardDAL.Rewards();

            Assert.Greater(r.Count, 0);
        }

        [Test]
        public void GetReceiptItems()
        {
            List<ReceiptItem> items = ReceiptDAL.ReceiptItems(1);

            Assert.Greater(items.Count, 0);
        }

        [Test]
        public void GetReceipt()
        {
            Receipt r = ReceiptDAL.GetReceipt(1);

            Assert.Greater(r.Id, 0);
        }

        [Test]
        public void UpdateReceipt()
        {
            //Arrange 
            Receipt r = null;
            int id = 0;

            //Act
            id = ReceiptDAL.UpdateReceipt(new Receipt() { Date = new DateTime(2012, 09, 12) });
            Console.WriteLine("The current test output: {0}", id);

            if (id > 0)
            {
                r = ReceiptDAL.GetReceipt(id);
            }

            //Assert
            Assert.Greater(r.Id, 0);
        }

        [Test]
        public static void UpdateReceiptItem()
        {
            string productName = ReceiptDAL.UpdateReceiptItem(1, new ReceiptItem() { Name = "strawb" });

            
        }
    }
}
