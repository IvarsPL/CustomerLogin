using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ER.Models;

namespace ER.Data
{
    public class ERContext : DbContext
    {
        public ERContext (DbContextOptions<ERContext> options)
            : base(options)
        {
        }

        public DbSet<ER.Models.Specialists> Specialists { get; set; }
    }
}
