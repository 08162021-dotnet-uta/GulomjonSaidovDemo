using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetStore;
using TargetStoreBusinessLayer;
using TargetStoreBusinessLayer.Interfaces;
using TargetStoreDbContext.Models;

namespace TargetStoreUi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoresController : Controller
    {

        private readonly IStoreRepository _storerepo;
        // Dependency Inversion - should not depend directly on the class, rather on the abstraction
        public StoresController(IStoreRepository sr)
        {
            _storerepo = sr;
        }

        // GET: StoreController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StoreController/Details/5
        [HttpGet("List")]
        //public List<ViewModelStore>Details()
        //{
        //    // call the business layer method to return the list of customers
        //    List<ViewModelStore> stores = _storerepo.Stores();

        //    return stores;
        //}
        public List<ViewModelStore> Get()
        {

            List<ViewModelStore> stores = _storerepo.Stores();
            return stores;
        }

        // GET: StoreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreController/Create
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

        // GET: StoreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreController/Edit/5
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

        // GET: StoreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreController/Delete/5
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
