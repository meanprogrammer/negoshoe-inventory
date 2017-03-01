using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NegoShoePH.Data;
using System.Data.Linq;

namespace NegoShoePH.DataTest
{
    [TestClass]
    public class UnitTest1
    {
        InventoryDataDataContext context = new InventoryDataDataContext();
        [TestInitialize()]
        public void CreateData()
        {
            context.ExecuteCommand("truncate table Items");

            context.Items.InsertOnSubmit(
                new Item() { 
                    ItemName = "Jordan 2 Wings Breds",
                    Quantity = 10,
                    Description = string.Empty,
                    Remarks = string.Empty
                }
                );

            context.SubmitChanges();
        }

        [TestCleanup()]
        public void CleanUp()
        {
            context.ExecuteCommand("truncate table Items");
        }

        [TestMethod]
        public void InsertTest()
        {
            Item i = new Item();
            i.ItemName = "Jordan Banned Breds Snapback";
            i.Quantity = 5;

            context.Items.InsertOnSubmit(i);
            var count = context.GetChangeSet().Inserts.Count;
            context.SubmitChanges();

            Assert.AreEqual(1, count);

        }

        [TestMethod]
        public void GetAllItemsTest()
        {
            using (InventoryDataDataContext context = new InventoryDataDataContext())
            {
                Table<Item> data = context.Items;
                Assert.IsNotNull(data);
            }
        }
    }
}