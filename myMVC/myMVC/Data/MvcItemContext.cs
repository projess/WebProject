using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myMVC.Models;

namespace myMVC.Data
{
    public class MvcItemContext : DbContext
    {
        public MvcItemContext(DbContextOptions<MvcItemContext> options)
            : base(options)
        {
        }
        public DbSet<Item> Item { get; set; }
    }
}


