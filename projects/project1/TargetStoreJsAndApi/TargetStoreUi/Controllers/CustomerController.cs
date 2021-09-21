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

        // POST: CustomerController/Create
        [HttpPost("register")]
        public async Task<ActionResult<ViewModelCustomer>> Create(ViewModelCustomer c)
        {
            if (!ModelState.IsValid) return BadRequest();

            //ViewModelCustomer c = new ViewModelCustomer() { Fname = fname, Lname = lname };
            // send fname and lname into a method of the business layer to check the Db for that person
            ViewModelCustomer c1 = await _customerrepo.RegisterCustomerAsync(c);
            if (c1 == null)
            {
                return NotFound();
            }

            return Created($"`~customer/{c1.CustomerId}", c1); 
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

        /// <summary>
        /// This method takes first and last names and returns a validated customer
        /// if not found, returns NotFound()    
        /// </summary>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <returns></returns>
        [HttpGet("login/{fname}/{lname}")]
        public async Task<ActionResult<ViewModelCustomer>> Login(string fname, string lname)
        {
            if (!ModelState.IsValid) return BadRequest();

            ViewModelCustomer c = new ViewModelCustomer() { Fname = fname, Lname = lname };
            // send fname and lname into a method of the business layer to check the Db for that person
            ViewModelCustomer c1 = await _customerrepo.LoginCustomerAsync(c);
            if (c1 == null)
            {
                return NotFound();
            }

            return Ok(c1);
        }
    }// EoC
}// EoN
