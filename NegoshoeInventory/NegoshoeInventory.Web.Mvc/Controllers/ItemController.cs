using NegoshoeInventory.Web.Mvc.Models;
using NegoShoePH.Common;
using NegoShoePH.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NegoshoeInventory.Web.Mvc.Controllers
{
    public class ItemController : Controller
    {
        ItemData data;
        BrandData bData;
        ProductTypeData pData;
        public ItemController()
        {
            data = new ItemData();
            bData = new BrandData();
            pData = new ProductTypeData();
        }

        // GET: Item
        public ActionResult Index()
        {
            List<Item> items = data.GetAllItem();
            return View(items);
        }

        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            var record = data.GetOne(id);
            return View(record);
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            ItemViewModel vm = new ItemViewModel();
            vm.Item = new Item();
            vm.Brands = ConvertToSelectListItemBrand(bData.GetAllBrand());
            vm.ProductType = ConvertToSelectListItemTypes(pData.GetAllProductType());
            return View(vm);
        }

        private SelectList ConvertToSelectListItemBrand(List<ItemBrand> brands) {
            brands.Insert(0, new ItemBrand() { Brand = "-- SELECT --", RecordID = 0 });
            return new SelectList(brands, "RecordID", "Brand", "test");
        }

        private SelectList ConvertToSelectListItemTypes(List<ItemType> prodTypes)
        {
            prodTypes.Insert(0, new ItemType() { ProductType = "-- SELECT --", RecordID = 0 });
            return new SelectList(prodTypes, "RecordID", "ProductType");
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult Create(Item item, HttpPostedFileBase Filename)
        {
            
            try
            {
                var files = Request.Files;
                var ext = Path.GetExtension(Filename.FileName);
                var filename = Path.GetFileNameWithoutExtension(Filename.FileName);

                if (Filename != null)
                {
                    byte[] imgBinary = ImageResizeHelper.ProcessResizeImage(Filename.InputStream);
                    //item.Image = new System.Data.Linq.Binary(imgBinary);
                    var base64image = Convert.ToBase64String(imgBinary);
                    item.Filename = filename;
                    item.ImageBase64 = base64image;
                }

                data.SaveItem(item);

                return RedirectToAction("Index", "Item");
            }
            catch (Exception ex)
            {
                //ModelState.AddModelError(string.Empty, ex.Message);
                ViewBag.Exception = ex.Message;
            }
             
            return View();
        }


        public static byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int id)
        {
            var record = data.GetOne(id);
            return View(record);
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Item item)
        {
            try
            {
                // TODO:     update logic here
                data.UpdateItem(item, id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            data.DeleteItem(id);
            return View("Index");
        }

        // POST: Item/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
