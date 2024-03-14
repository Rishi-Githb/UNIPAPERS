using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UNIPAPERS.Models;

namespace UNIPAPERS.Data
{
    public class UNIPAPERSContext : IdentityDbContext
    {
        public UNIPAPERSContext (DbContextOptions<UNIPAPERSContext> options)
            : base(options)
        {
        }

        public DbSet<UNIPAPERS.Models.Paper> Paper { get; set; } = default!;
        public DbSet<UNIPapers.Models.Customer> Customer { get; set; }
    }
}
