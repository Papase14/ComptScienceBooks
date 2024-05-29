using Microsoft.AspNetCore.Mvc;
using ComptScienceBooks.Data;
using ComptScienceBooks.Data.Data_Access;
using ComptScienceBooks.Models;
using ComptScienceBooks.Models.ViewModels;

namespace ComptScienceBooks.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
      
        public CategoryController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        } 
        
        public IActionResult Artificial()
        {
            return View();
        }
        public IActionResult Machine()
        {
            var category = _repositoryWrapper.Category.GetCategoryWithBooks(5); // Assume 5 is the ID for Machine category
            return View(category);
        }
        public IActionResult Programming()
        {
            return View();
        }
        public IActionResult Security()
        {
            return View();
        }
        public IActionResult Software()
        {
            return View();
        }
    }
}
