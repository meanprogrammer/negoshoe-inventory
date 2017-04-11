using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NegoshoeInventory.Web.Mvc.Models
{
    public class IndexItemViewModel
    {
        public IndexItemViewModel() { }
        public IEnumerable<NegoShoePH.Data.Item> Items { get; set; }
        public SelectList Brands { get; set; }
        public int BrandID { get; set; }
        public SelectList ProductType { get; set; }
        [Display(Name="Product Type")]
        public int ProductTypeID { get; set; }
    }
}