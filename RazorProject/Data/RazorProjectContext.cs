#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorProject.Model;

namespace RazorProject.Data
{
    public class RazorProjectContext : DbContext
    {
        public RazorProjectContext(DbContextOptions<RazorProjectContext> options)
            : base(options)
        {
        }

        public DbSet<RazorProject.Model.Movie>? Movie { get; set; }
    }
}
