using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    // create the context for the model
    public class BookDbContext : DbContext
    {

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }

        internal object GetPendingMigrations()
        {
            throw new NotImplementedException();
        }
    }
}
