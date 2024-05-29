using ComptScienceBooks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ComptScienceBooks.Data
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(BookDbContext bookDbContext) : base(bookDbContext) { }

        public Category GetCategoryWithBooks(int categoryId)
        {
            return _bookDbContext.Categories
                                 .Include(c => c.Books)
                                 .FirstOrDefault(c => c.Id == categoryId);
        }
    }
}
