﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject.ModelAccessLayer.Model;


namespace WebProject.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog

        public ActionResult Items(int? idCategory, int? idSubCategory)
        {
            if (idCategory.HasValue && idSubCategory.HasValue)
            {
                Category category = AccountController.guest.GetCategoriesCatalog(idCategory.Value, idSubCategory.Value);
                return View(category);
            }
            else
            {
                return RedirectToAction("Error404", "Home");
            }
        }
        public ActionResult Item(int? id)
        {
            if (id.HasValue)
            {
                Product product = AccountController.guest.GetProductById(id.Value);
                if (product != null)
                    return View(product);
                else
                    return RedirectToAction("Error", "Home");
            }
            else
            {
                return RedirectToAction("Error404", "Home");
            }
        }
    }
}