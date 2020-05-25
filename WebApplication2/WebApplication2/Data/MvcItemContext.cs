using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class MvcItemContext: DbContext
    {
        public MvcItemContext(DbContextOptions<MvcItemContext> options)
           : base(options)
        {
        }
        public DbSet<Item> Item { get; set; }
    }
}
