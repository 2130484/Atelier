using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCVetement.Models;

namespace Vetements.Data
{
    public class VetementsContext : DbContext
    {
        public VetementsContext (DbContextOptions<VetementsContext> options)
            : base(options)
        {
        }

        public DbSet<MVCVetement.Models.Vetement> Vetement { get; set; } = default!;
    }
}
