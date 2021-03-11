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

// The next step is to create a repository interface and implementation class. The repository pattern is 
// one of the most widely used, and it provides a consistent way to access the features presented by the database context class. 
// Not everyone finds a repository useful, but my experience is that it can reduce duplication and ensures that operations 
// on the database are performed consistently. Add a class file named IStoreRepository.cs to the Models folder 

//This interface uses IQueryable<T> to allow a caller to obtain a sequence of Product objects. 
// The IQueryable<T> interface is derived from the more familiar IEnumerable<T> interface and 
// represents a collection of objects that can be queried, such as those managed by a database.

// A class that depends on the IProductRepository interface can obtain Product objects without needing to know the details of 
// how they are stored or how the implementation class will deliver them.