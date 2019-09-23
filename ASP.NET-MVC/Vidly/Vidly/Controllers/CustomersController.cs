using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // New Customer Form
        // -------------------------------------------------------------
        public IActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            }; 
            return View(viewModel);
        }
        // Edit Customer Form
        // -------------------------------------------------------------
        public IActionResult Edit(int id)
        {
            // Get the customer with the specific Id from the db
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            
            // If existing customer exist in db it will be returned otherwise null 
            if (customer == null)
            {
                return BadRequest();
            }

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }

        // Save Action Setup
        // -------------------------------------------------------------
        [HttpPost]
        // Token validation
        [ValidateAntiForgeryToken]
        public IActionResult Save(Customer customer)
        {
            // Adding Validations
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustomerForm", viewModel);
            }
            // Check if Id == 0 and if it is then it means it is a new customer
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
               // To update an entity we need to retrieve it from db 1st
               var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
               
               // Modify Props either by 
                    // 1) TryUpdateModel() method

//                    TryUpdateModelAsync(customerInDb);

                    // 2) Manually set the props of customer objs
                    
                    customerInDb.Name = customer.Name;
                    customerInDb.Birthdate = customer.Birthdate;
                    customerInDb.MembershipType = customer.MembershipType;
                    customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
                        
                        // Or USE AutoMapper Library - AutoMapper: Convention based Mapping tool

    //                    Mapper.Map(customer, customerInDb);

            }
            
            // Save Changes
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                Console.WriteLine(e);
                throw;
            }
            

            return RedirectToAction("Index", "Customers");
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return BadRequest();

            return View(customer);
        }
    }
}