using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{   
    // create the repository for the model
    public class EFBookRepository : IBookRepository
    {
        private BookDbContext _context;

        public EFBookRepository(BookDbContext context)
        {
            _context = context;
        }
        public IQueryable<Project> Projects => _context.Projects;

    }
}

// To create an implementation of the repository interface, add a class file named EFStoreRepository.cs in the Models folder and use it to define the class


