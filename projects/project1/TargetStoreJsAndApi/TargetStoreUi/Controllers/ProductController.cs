using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetStore;
using TargetStoreBusinessLayer.Interfaces;

namespace TargetStoreUi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productrepo;
        // Dependency Inversion - should not depend directly on the class, rather on the abstraction
        public ProductController(IProductRepository pr)
        {
            _productrepo = pr;
        }
            // GET: ProductController
            public ActionResult Index()
        {
            return View();
        }

        // GET: ProductController/Details/5
        [HttpGet("lists")]
        public List<ViewModelProduct> Details()
        {

            List<ViewModelProduct> products = _productrepo.Products();
            return products;
        }

        // GET: ProductController/Details/5
        [HttpGet("lists/{id}")]
        public List<ViewModelProduct> GetByStore(int id)
        {

            List<ViewModelProduct> products = _productrepo.ProductsByStore(id);
            return products;
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
