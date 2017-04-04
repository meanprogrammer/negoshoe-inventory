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

        public bool UpdateItem(Item i, int recordId)
        {
            var record = context.Items.Where(c=>c.RecordID == recordId).FirstOrDefault();

            if(record == null) { return false; }

            record = i;
            record.RecordID = recordId;

            int result = context.GetChangeSet().Updates.Count;

            context.SubmitChanges();
            return result > 0;
        }

        public bool DeleteItem(int recordId)
        {
            var record = context.Items.Where(c => c.RecordID == recordId).FirstOrDefault();

            if (record == null) { return false; }

            context.Items.DeleteOnSubmit(record);

            int result = context.GetChangeSet().Deletes.Count;

            context.SubmitChanges();
            return result > 0;
        }
    }
}
