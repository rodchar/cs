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
        public void GetReceipts()
        {
            Console.WriteLine("\nTODO GetReceipts Test");
         
            Assert.Inconclusive();
        }
    }
}
