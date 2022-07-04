using Agenda_Back.Data;
using Agenda_Back.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Agenda_Back.Controllers
{
    public class CustomersController : ApiController
    {
        private Agenda_BackContext db = new Agenda_BackContext();

        public IQueryable<Customer> GetCustomers() 
        {
            return db.Customers.Include("Addresses");
        }

        public IHttpActionResult GetCustomer(int id)
        {
            IList<Customer> customers = db.Customers.Include("Address")
                                                    .Where(c => c.CustomerID == id)
                                                    .Select(c => new Customer()
            {
                CustomerID = c.CustomerID,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Address = c.Address == null ? null : new Address()
                {
                    CustomerID = c.Address.CustomerID,
                    AddressID = c.Address.AddressID,
                    AddressDescription = c.Address.AddressDescription
                }
            }).ToList<Customer>();

            if (customers.Count == 0)
            {
                return NotFound();
            }

            return Ok(customers);
        }

        public IHttpActionResult PostCustomer(Customer model)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            db.Customers.Add(new Customer() 
            {
                CustomerID = model.CustomerID,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address == null ? null : new Address()
                {
                    AddressID = model.Address.AddressID,
                    AddressDescription = model.Address.AddressDescription
                }
            });
            db.SaveChanges();

            return Ok();
        }
    }
}
