﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string sku { get; set; }

        public string Name { get; set; }
        

        public int Price { get; set; }
        public int Stock { get; set; }

        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

       
        public string Image { get; set; }
        public bool Status { get; set; }

        public List<Cart> Carts { get; set; }

        public List<InvoiceDetail> InvoiceDetails { get; set; }


    }
}
