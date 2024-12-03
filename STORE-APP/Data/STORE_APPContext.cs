using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using STORE_APP.Models;

namespace STORE_APP.Data
{
    public class STORE_APPContext : DbContext
    {
        public STORE_APPContext (DbContextOptions<STORE_APPContext> options)
            : base(options)
        {
        }

        public DbSet<STORE_APP.Models.Products> Products { get; set; } = default!;
    }
}
