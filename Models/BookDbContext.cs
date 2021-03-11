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

// Entity Framework Core provides access to the database through a context class. 
//
// The DbContext base class provides access to the Entity Framework Core’s underlying functionality, and the Products property 
// will provide access to the Product objects in the database. The StoreDbContext class is derived from DbContext and adds the properties that 
// will be used to read and write the application’s data. There is only one property for now, which will provide access to Product objects.