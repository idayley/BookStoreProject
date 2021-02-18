using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
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
