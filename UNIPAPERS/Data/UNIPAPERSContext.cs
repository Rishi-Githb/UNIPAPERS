using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UNIPAPERS.Models;

namespace UNIPAPERS.Data
{
    public class UNIPAPERSContext : DbContext
    {
        public UNIPAPERSContext (DbContextOptions<UNIPAPERSContext> options)
            : base(options)
        {
        }

        public DbSet<UNIPAPERS.Models.Paper> Paper { get; set; } = default!;
    }
}
