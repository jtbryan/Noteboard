using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Noteboard.Model
{
    // DbContext is found in EntityFrameworkCore
    public class ApplicationDbContext : DbContext
    {
        // parameters in base() are needed for dependency injection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Note> Note {get;set;}
    }
}