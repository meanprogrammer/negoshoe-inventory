using NegoShoePH.Data;
using NegoShoePH.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NegoshoeInventory.Web.Mvc.Models
{
    public class ItemViewModel
    {
        public ItemViewModel() { }
        public NegoShoePH.Data.Item Item { get; set; }
        public SelectList Brands { get; set; }
        public SelectList ProductType { get; set; }
        public string Filename { get; set; }
    }
}