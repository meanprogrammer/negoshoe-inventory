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
        public ItemController()
        {
            data = new ItemData();
        }

        // GET: Item
        public ActionResult Index()
        {
            return View();
        }

        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            return View();
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
                var completeFilename = string.Format("{0}_{1}{2}", filename, Guid.NewGuid().ToString(), ext);
                var uploadspath = Server.MapPath("~/App_Data/uploads");
                var fullPath = Path.Combine(uploadspath, completeFilename);

                ViewBag.path = fullPath;
                if (Filename != null)
                {
                    byte[] imgBinary = ReadFully(Filename.InputStream);
                    item.Image = new System.Data.Linq.Binary(imgBinary);
                    item.Filename = filename;
                }

                data.SaveItem(item);

                return RedirectToAction("Index", "Home");
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
            return View();
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
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
