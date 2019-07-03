﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClothBazaar.Entities;

namespace ClothBazaar.Database
{
    class CBContext: DbContext
    {
        public CBContext (): base("ClothBazaarConnection")
        {
            }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
