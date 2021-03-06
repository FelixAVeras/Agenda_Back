using Agenda_Back.Models;
using System.Data.Entity;

namespace Agenda_Back.Data
{
    public class Agenda_BackContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public Agenda_BackContext() : base("name=Agenda_BackContext")
        {
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
