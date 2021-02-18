using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    // create the interface for the model to inherit from 
    public interface IBookRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
