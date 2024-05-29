﻿using ComptScienceBooks.Models;

namespace ComptScienceBooks.Data
{
    public interface ICategoryRepository:IRepositoryBase<Category>
    {
        Category GetCategoryWithBooks(int categoryId);
    }
}
