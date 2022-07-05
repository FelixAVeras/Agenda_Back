using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Agenda_Back.Data;
using Agenda_Back.Models;

namespace Agenda_Back.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly Agenda_BackContext db = new Agenda_BackContext();

        public IHttpActionResult GetAllCustomers()
        {
            IList<Customer> customers = db.Customers.Include("Addresses").Select(c => new Customer()
            {
                CustomerID = c.CustomerID,
                FirstName = c.FirstName,
                LastName = c.LastName,
                //Address = c.Address == null ? null : new Address()
                //{
                //    AddressID = c.Address.AddressID,
                //    AddressDescription = c.Address.AddressDescription
                //}
            }).ToList<Customer>();

            if (customers.Count == 0)
            {
                return NotFound();
            }

            return Ok(customers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CustomerExists(int id)
        {
            return db.Customers.Count(e => e.CustomerID == id) > 0;
        }
    }
}