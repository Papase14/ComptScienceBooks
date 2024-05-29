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

        public IActionResult HumanComputer()
        {
            var category = _repositoryWrapper.Category.GetCategoryWithBooks(4);
            return View(category);
        }
        public IActionResult Machine()
        {
            var category = _repositoryWrapper.Category.GetCategoryWithBooks(5);
            return View(category);
        }
        public IActionResult Programming()
        {
            var category = _repositoryWrapper.Category.GetCategoryWithBooks(3);
            return View(category);
        }
        public IActionResult Security()
        {
            var category = _repositoryWrapper.Category.GetCategoryWithBooks(1);
            return View(category);
        }
        public IActionResult Software()
        {
            var category = _repositoryWrapper.Category.GetCategoryWithBooks(2);
            return View(category);
        }
    }
}
