using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegoShoePH.Data
{
    [MetadataType(typeof(ItemMetaData))]
    public partial class Item
    {
        public string BrandName { get; set; }
        public string ProductTypeName { get; set; }
    }

    public class ItemMetaData
    {
        [Display(Name="Brand")]
        public int Brand { get; set; }

        [Display(Name = "Product Type")]
        public int ProductType { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Item Name")]
        public string ItemName { get; set; }

        [Display(Name = "Total Qty.")]
        public int TotalQuantity { get; set; }

        [Display(Name = "Office Qty.")]
        public int OfficeQuantity { get; set; }

        [Display(Name = "House Qty.")]
        public int HouseQuantity { get; set; }

    }
}
