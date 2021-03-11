using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookStoreProject.Models;
using BookStoreProject.Infrastructure;

namespace BookStoreProject.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookRepository repository;

        // Constructor
        public PurchaseModel(IBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        // Properties
        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        // Methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Project project = repository.Projects
                .FirstOrDefault(p => p.BookID == bookId);

            Cart.AddItem(project, 1);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Project.BookID == bookId).Project);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
