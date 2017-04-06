using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegoShoePH.Data
{
    public class BrandData
    {
        InventoryDataDataContext context = null;
        public BrandData() {
            context = new InventoryDataDataContext();
        }

        public List<ItemBrand> GetAllBrand() {
            return context.ItemBrands.OrderBy(c => c.RecordID).ToList();
        }

        public ItemBrand GetOne(int recordId) {
            return context.ItemBrands.Single(c => c.RecordID == recordId);
        }
    }

    public class ProductTypeData
    {
        InventoryDataDataContext context = null;
        public ProductTypeData() {
            context = new InventoryDataDataContext();
        }

        public List<ItemType> GetAllProductType() {
            return context.ItemTypes.OrderBy(c => c.RecordID).ToList();
        }

        public ItemType GetOne(int recordId)
        {
            return context.ItemTypes.Single(c=>c.RecordID == recordId);
        }
    }
}
