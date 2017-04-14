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
            var result = context.Items.Single(c => c.RecordID == id);
            result.BrandName = context.ItemBrands.Single(c => c.RecordID == result.Brand).Brand;
            result.ProductTypeName = context.ItemTypes.Single(c => c.RecordID == result.ProductType).ProductType;

            return result;
        }

        public List<Item> GetAllItem(int brandId, int typeId)
        {
            var list = context.Items.ToList();

            if (brandId > 0 && typeId > 0)
            {
                list = list.Where(c => c.Brand == brandId && c.ProductType == typeId).ToList() ;
            }
            else if (brandId > 0 && typeId == 0)
            {
                list = list.Where(c => c.Brand == brandId).ToList();
            }
            else if (typeId > 0 && brandId == 0)
            {
                list = list.Where(c => c.ProductType == typeId).ToList();
            }
            else
            { 

            }

            foreach (Item item in list)
            {
                item.BrandName = context.ItemBrands.Single(c => c.RecordID == item.Brand).Brand;
                item.ProductTypeName = context.ItemTypes.Single(c => c.RecordID == item.ProductType).ProductType;
            }

            return list;
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
            if (record.Brand != i.Brand) { record.Brand = i.Brand; }
            if (record.ProductType != i.ProductType) { record.ProductType = i.ProductType; }
            if (record.ItemName != i.ItemName) { record.ItemName = i.ItemName; }
            if (record.OfficeQuantity != i.OfficeQuantity) { record.OfficeQuantity = i.OfficeQuantity; }
            if (record.TotalQuantity != i.TotalQuantity) { record.TotalQuantity = i.TotalQuantity; }
            if (record.HouseQuantity != i.HouseQuantity) { record.HouseQuantity = i.HouseQuantity; }
            if (record.ImageBase64 != i.ImageBase64 && i.ImageBase64 != null) { record.ImageBase64 = i.ImageBase64; }
            if (record.Description != i.Description) { record.Description = i.Description; }
            if (record.Filename != i.Filename && i.Filename != null) { record.Filename = i.Filename; }
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
