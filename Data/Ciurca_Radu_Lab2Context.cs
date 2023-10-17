﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciurca_Radu_Lab2.Models;

namespace Ciurca_Radu_Lab2.Data
{
    public class Ciurca_Radu_Lab2Context : DbContext
    {
        public Ciurca_Radu_Lab2Context (DbContextOptions<Ciurca_Radu_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ciurca_Radu_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ciurca_Radu_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Ciurca_Radu_Lab2.Models.Author>? Author { get; set; }
    }
}
