﻿using library_management.Data.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.Data
{
    public class DbInitialize
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LibraryDbContext>();

                // Add Customers
                var justin = new Customer { Name = "Justin Noon" };

                var willie = new Customer { Name = "Willie Parodi" };

                var leoma = new Customer { Name = "Leoma Gosse" };

                context.Customers.Add(justin);
                context.Customers.Add(willie);
                context.Customers.Add(leoma);

                //Add Author
                var authorDeMarco = new Author
                {
                    Name = "M J DeMarco",
                    Books = new List<Book>()
                    {
                        new Book { Title = "The Millionaire Fastlane" },
                        new Book { Title = "Inscripted" }
                    }
                };

                var authorCardone = new Author
                {
                    Name = "Grant Cardone",
                    Books = new List<Book>()
                {
                        new Book { Title = "The 10x Rule"},
                        new Book { Title = "If You're Not First, You're Last"},
                        new Book { Title = "Sell to Survive"}
                }
                };

                context.Authors.Add(authorDeMarco);
                context.Authors.Add(authorCardone);

                context.SaveChanges();
            }
        }
    }
}
