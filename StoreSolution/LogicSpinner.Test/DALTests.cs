using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data;

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
            DataTable p = ProductDAL.GetProducts();

            Assert.Greater(p.Rows.Count, 0);
        }

        [Test]
        public void GetProductsNotMatchedYet()
        {
            BpDS.ProductsDataTable dt =  ProductDAL.ProductsNotMatchedYet();

            Assert.Greater(dt.Rows.Count, 0);

        }

        [Ignore("Updates Database - AddProduct")]
        [Test]
        public void AddProduct()
        {
            ProductDAL.UpdateProduct(new Product() { Name = "cranberry" });
        }

        [Ignore("Updates Database - UpdateProduct")]
        [Test]
        public void UpdateProduct()
        {
            ProductDAL.UpdateProduct(new Product() {Id = 6, Name = "cranberry2" });
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

        [Ignore("Updates Database - UpdateReceipt")]
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

        [Ignore("Updates Database - UpdateReceiptItem")]
        [Test]
        public static void UpdateReceiptItem()
        {
            string productName = ReceiptDAL.UpdateReceiptItem(1, new ReceiptItem() { Name = "strawb" });


        }

        [Ignore("Updates Database - UpdateReceiptItemName")]
        [Test]
        public static void UpdateReceiptItemName()
        {
            ReceiptDAL.UpdateReceiptItemName(new ReceiptItemName() { Id = 1, Name = "strawb4" });
        }

        [Ignore("Updates Database - AddReceiptItemName")]
        [Test]
        public static void AddReceiptItemName()
        {
            ReceiptDAL.UpdateReceiptItemName(new ReceiptItemName() { Name = "ban" });
        }

        [Test]
        public static void ReceiptItemNamesNotMatchedYet()
        {
            BpDS.ReceiptItemNamesDataTable dt = ReceiptDAL.ReceiptItemNamesNotMatchedYet();

            Assert.Greater(dt.Rows.Count, 0);
        }
    }
}
