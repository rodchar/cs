using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LogicSpinner.Test
{
    [TestFixture]
    public class BusinessTests
    {
        [SetUp]
        protected void Setup() { }

        [TearDown]
        protected void TearDown() { }

        [Test]
        public static void SpinnerLogic_Result_Has_Count_Of_2()
        {
            //Arrange
            List<Reward> rewards = Rewards();
            List<ReceiptItem> receiptItems = ReceiptItems();

            //Action
            rewards = Business.Rewards(rewards, receiptItems);

            //Assert
            Assert.AreEqual(rewards.Count, 2);

            //Output
            Console.WriteLine();
            Console.WriteLine("SpinnerLogic_Result_Has_Count_Of_2");
            rewards.ForEach(r => Console.WriteLine(r.ProductCsv));
        }

        [Test]
        public void Slow_SpinnerLogic_with_database()
        {
            //Arrange
            //Get Receipt Id
            int receiptId = 1;
            //Get Receipt Items by Receipt Id
            List<ReceiptItem> receiptItems = ReceiptDAL.ReceiptItems(receiptId);

            //Get Rewards that have product name in
            // table Rewards column ProductCsv. 
            List<Reward> relatedRewards = RewardDAL.Rewards(receiptItems);

            //Action
            //Run these results through SpinnerLogic
            // using Business.Rewards(ReceiptItems,rewards)
            List<Reward> rewards = Business.Rewards(relatedRewards, receiptItems);
            
            //Assert
            Assert.AreEqual(rewards.Count, 3);

            //Output
            Console.WriteLine();
            Console.WriteLine("Slow_SpinnerLogic_Result_Has_Count_Of_3");
            rewards.ForEach(r => Console.WriteLine(r.ProductCsv));
        }

        private static List<ReceiptItem> ReceiptItems()
        {
            List<ReceiptItem> receiptItems = new List<ReceiptItem>();

            receiptItems.Add(new ReceiptItem() { Id = 1, Name = "banana" });
            receiptItems.Add(new ReceiptItem() { Id = 2, Name = "banana" });
            receiptItems.Add(new ReceiptItem() { Id = 3, Name = "kiwi" });
            receiptItems.Add(new ReceiptItem() { Id = 4, Name = "strawberry" });

            return receiptItems;
        }

        private static List<Reward> Rewards()
        {
            List<Reward> toReturn = new List<Reward>();
            toReturn.Add(new Reward() { Id = 1, ProductCsv = "banana,strawberry" });
            toReturn.Add(new Reward() { Id = 2, ProductCsv = "strawberry" });
            toReturn.Add(new Reward() { Id = 3, ProductCsv = "banana,banana,banana" });
            toReturn.Add(new Reward() { Id = 4, ProductCsv = "banana,banana,orange" });

            return toReturn;
        }
    }
}
