using System.Collections.Generic;
using System.Linq;
using DatabaseAceesLayer.Models;

namespace DatabaseAceesLayer.Repo
{
    public static class CategoryRepository
    {
        private static readonly NewDBContext Context;

        static CategoryRepository()
        {
            Context = new NewDBContext();
        }

        public static IEnumerable<Category> GetAllCategories()
        {
            return Context.Categories.ToList();
        }

        public static Category GetCategoryById(int id)
        {
            return Context.Categories.Find(id);
        }

        public static bool AddCategory(Category category)
        {
            Context.Categories.Add(category);
            return Context.SaveChanges() > 0;
        }

        public static bool UpdateCategory(Category category)
        {
            var dbcategory = Context.Categories.Find(category.Id);
            Context.Entry(dbcategory).CurrentValues.SetValues(category);
            return Context.SaveChanges() > 0;
        }

        public static bool DeleteCategory(int id)
        {
            var category = Context.Categories.Find(id);
            Context.Categories.Remove(category);
            return Context.SaveChanges() > 0;
        }
    }
}