﻿using Eshop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Data
{
    public class EshopContext : DbContext
    {
        public EshopContext(DbContextOptions<EshopContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Product> Prodcuts { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<Cart> Carts { get; set; }

    }
}
