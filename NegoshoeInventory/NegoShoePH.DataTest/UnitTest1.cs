using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NegoShoePH.Data;
using System.Data.Linq;

namespace NegoShoePH.DataTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GetAllItemsTest()
        {
            using (InventoryDataDataContext context = new InventoryDataDataContext())
            {
                Table<Item> data = context.Items;
             
            }
        }
    }
}
