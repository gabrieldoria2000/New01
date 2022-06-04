using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using New01.Models;

namespace New01.Data
{
    public class New01Context : DbContext
    {
        public New01Context (DbContextOptions<New01Context> options)
            : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
    }
}
