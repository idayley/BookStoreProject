using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    // setup cart 
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        // create cartline 
        public virtual void AddItem (Project proj, int qty)
        {
            CartLine line = Lines
                .Where(p => p.Project.BookID == proj.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Project = proj,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }

        }

        // Remove one line from cart
        public virtual void RemoveLine(Project proj) =>
            Lines.RemoveAll(x => x.Project.BookID == proj.BookID);

        // Clear the whole cart
        public virtual void Clear() => Lines.Clear();

        // compute the total price of the cart
        public decimal ComputeTotalSum() => Lines.Sum(e => (decimal)(e.Project.Price) * e.Quantity);


        // Class for storing cart
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Project Project { get; set; }
            public int Quantity { get; set; }

        }

    }
}
