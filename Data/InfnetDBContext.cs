using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tp03_.netApp.Models;

    public class InfnetDBContext : DbContext
    {
        public InfnetDBContext (DbContextOptions<InfnetDBContext> options)
            : base(options)
        {
        }

        public DbSet<Tp03_.netApp.Models.Computador> Computador { get; set; } = default!;
    }
