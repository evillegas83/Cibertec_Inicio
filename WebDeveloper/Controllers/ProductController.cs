﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private ProductData _product;

        public ProductController(ProductData product)
        {
            _product = product;
        }

        public ActionResult Index()
        {
           ViewBag.Title = Resources.Resource.Product_Title;
            return View(_product.GetList());
        }

        public ActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            var obj = _product. GetProductById(id);

            if (obj == null)
                RedirectToAction("Index");
            return View(obj);

        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.Update(product);
                return RedirectToAction("Index");
            }
            return View();
        }


        public ActionResult Delete(int id = 0)
        {

            var obj = _product.GetProductById(id);

            if (obj == null)
                RedirectToAction("Index");
            return View(obj);


        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            if (_product.Delete(product) > 0)
                return RedirectToAction("Index");
            return View(product);

        }

    }
}