using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookStoreProject.Models;
using BookStoreProject.Models.ViewModels;

namespace BookStoreProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookRepository _repository;

        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        // Push stored model from database to view
        public IActionResult Index(int page = 1)
        {
            return View(new ProjectListViewModel
            {
                Projects = _repository.Projects
                    .OrderBy(p => p.BookID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                    
                ,
                Paginginfo = new Paginginfo
                {
                    CurrentPage = page, 
                    ItemsPerPage = PageSize, 
                    TotalNumItems = _repository.Projects.Count()
                }


            });
                
                
                
                
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
