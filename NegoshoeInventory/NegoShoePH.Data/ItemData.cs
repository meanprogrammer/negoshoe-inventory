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

        public Item GetOne(int id) 
        {
            return context.Items.Where(c => c.RecordID == id).FirstOrDefault();
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
            Item record = context.Items.Single(c=>c.RecordID == recordId);

            if(record == null) { return false; }

            if (record.ItemName != i.ItemName) { record.ItemName = i.ItemName; }
            if (record.OfficeQuantity != i.OfficeQuantity) { record.OfficeQuantity = i.OfficeQuantity; }
            if (record.TotalQuantity != i.TotalQuantity) { record.TotalQuantity = i.TotalQuantity; }
            if (record.HouseQuantity != i.HouseQuantity) { record.HouseQuantity = i.HouseQuantity; }
            if (record.ImageBase64 != i.ImageBase64) { record.ImageBase64 = i.ImageBase64; }
            if (record.Description != i.Description) { record.Description = i.Description; }
            if (record.Filename != i.Filename) { record.Filename = i.Filename; }
            if (record.Remarks != i.Remarks) { record.Remarks = i.Remarks; }
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
