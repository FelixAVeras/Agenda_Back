namespace Agenda_Back.Migrations
{
    using Agenda_Back.Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.Agenda_BackContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Data.Agenda_BackContext context)
        {
            context.Customers.AddOrUpdate(
                c => c.CustomerID,
                new Customer 
                { 
                    FirstName = "Adrian", 
                    LastName = "Cespedes",
                    Address = new List<Address>
                    {
                        new Address { AddressDescription = "Calle luna, Calle Sol" }
                    }
                },
                new Customer
                {
                    FirstName = "Miguelina",
                    LastName = "Antonietta",
                    Address = new List<Address>
                    {
                        new Address { AddressDescription = "Avenida Primera" },
                        new Address { AddressDescription = "Calle segunda" }
                    }
                },
                new Customer
                {
                    FirstName = "Marcos",
                    LastName = "Soto",
                    Address = new List<Address>
                    {
                        new Address { AddressDescription = "Calle A" },
                        new Address { AddressDescription = "Calle B" },
                        new Address { AddressDescription = "Calle C" }
                    }
                }
            );

            
            //customersWithAddress.ForEach(c => context.Customers.Add(c));
            
        }
    }
}