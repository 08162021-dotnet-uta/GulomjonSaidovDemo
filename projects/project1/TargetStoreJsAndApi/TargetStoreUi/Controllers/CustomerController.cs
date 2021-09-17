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
    public class CustomerController : Controller
    {

        private readonly ICustomerRepository _customerrepo;
        // Dependency Inversion - should not depend directly on the class, rather on the abstraction
        public CustomerController(ICustomerRepository cr)
        {
            _customerrepo = cr;
        }
        // GET: CustomerController - conventional routing
        // Attribute routing involves using attributes to define the path
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerController/Details/5
        [HttpGet("Customerlist")]
        public async Task<ActionResult<List<ViewModelCustomer>>> Details()
        {
            // call the business layer method to return the list of customers
            Task<List<ViewModelCustomer>> customers = _customerrepo.CustomerListAsync();

            List<ViewModelCustomer> customers1 = await customers;
            return customers1;
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
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

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
