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
        BpDSTableAdapters.ReceiptsTableAdapter da;
        BpDS.ReceiptsDataTable dt;

        [SetUp]
        protected void SetUp()
        {
            da = new BpDSTableAdapters.ReceiptsTableAdapter(); 
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
            dt = da.GetDataBy(4);

            Assert.Greater(dt.Rows.Count, 0);
        }

        [Test]
        public void UpdateReceipt()
        {
            //Arrange 
            int id = 0;

            //Act
            string retval = ReceiptDAL.UpdateReceipt(new Receipt() { Date = new DateTime(2012, 09, 12) });
            Console.WriteLine("The current test output: {0}", retval);
            int.TryParse(retval, out id);

            if (id > 0)
            {
                dt = da.GetDataBy(id);
            }

            //Assert
            Assert.Greater(dt.Rows.Count, 0);

        }
    }
}
