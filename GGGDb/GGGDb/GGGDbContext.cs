﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGGDb
{
    public class GGGDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
