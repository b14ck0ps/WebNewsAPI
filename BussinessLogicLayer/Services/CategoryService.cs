using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.DTOs;
using DatabaseAceesLayer.Models;
using DatabaseAceesLayer.Repo;

namespace BussinessLogicLayer.Services
{
    public static class CategoryService
    {
        public static List<CategoryDTO> GetAllCategories()
        {
            var data = CategoryRepository.GetAllCategories();
            return CategoryConverter(data);
        }
        public static CategoryDTO GetCategoryById(int id)
        {
            var data = CategoryRepository.GetCategoryById(id);
            return CategoryConverter(data);
        }
        public static bool AddCategory(CategoryDTO category)
        {
            var data = CategoryConverter(category);
            return CategoryRepository.AddCategory(data);
        }

        public static bool UpdateCategory(CategoryDTO category)
        {
            var data = CategoryConverter(category);
            return CategoryRepository.UpdateCategory(data);
        }

        public static bool DeleteCategory(int id)
        {
            return CategoryRepository.DeleteCategory(id);
        }

        //CategoryConverter
        private static List<CategoryDTO> CategoryConverter(IEnumerable<Category> data)
        {
            return data.Select(CategoryConverter).ToList();
        }

        private static CategoryDTO CategoryConverter(Category data)
        {
            var category = new CategoryDTO()
            {
                Id = data.Id,
                Name = data.Name,
            };
            return category;
        }

        private static Category CategoryConverter(CategoryDTO data)
        {
            var category = new Category()
            {
                Id = data.Id,
                Name = data.Name,
            };
            return category;
        }
    }
}