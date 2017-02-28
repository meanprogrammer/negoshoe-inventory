using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegoShoePH.Data
{
    public class ItemData
    {
        InventoryDataDataContext context = null;
        public ItemData() {
            context = new InventoryDataDataContext();
        }

        public List<Item> GetAllItem()
        {
            return context.Items.ToList();
        }

        public bool SaveItem(Item i)
        {
            context.Items.InsertOnSubmit(i);
            int result = context.GetChangeSet().Inserts.Count;
            context.SubmitChanges();
            return result > 0;
        }
    }
}
