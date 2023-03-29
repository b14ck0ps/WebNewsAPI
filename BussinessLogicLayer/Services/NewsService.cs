using System;
using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.DTOs;
using DatabaseAceesLayer.Models;
using DatabaseAceesLayer.Repo;

namespace BussinessLogicLayer.Services
{
    public static class NewsService
    {
        public static List<NewsDTO> GetAllNews()
        {
            var data = NewsRepository.GetAllNews();
            return NewsConverter(data);
        }


        public static NewsDTO GetNewById(int id)
        {
            var data = NewsRepository.GetNewById(id);
            return NewsConverter(data);
        }

        public static List<NewsDTO> GetNewsByCategoryName(string name)
        {
            var data = NewsRepository.GetNewsByCategoryName(name);
            return NewsConverter(data);
        }

        public static List<NewsDTO> GetNewsByDate(DateTime date)
        {
            var data = NewsRepository.GetNewsByDate(date);
            return NewsConverter(data);
        }

        public static List<NewsDTO> GetNewsByCategoryAndDate(string name, DateTime date)
        {
            var data = NewsRepository.GetNewsByCategoryAndDate(name, date);
            return NewsConverter(data);
        }

        public static bool AddNews(NewsDTO news)
        {
            var data = NewsConverter(news);
            return NewsRepository.AddNews(data);
        }

        public static bool UpdateNews(NewsDTO news)
        {
            var data = NewsConverter(news);
            return NewsRepository.UpdateNews(data);
        }

        public static bool DeleteNews(int id)
        {
            return NewsRepository.DeleteNews(id);
        }

        //Converters
        private static List<NewsDTO> NewsConverter(IEnumerable<News> data)
        {
            return data.Select(NewsConverter).ToList();
        }

        private static NewsDTO NewsConverter(News data)
        {
            var news = new NewsDTO()
            {
                Id = data.Id,
                Title = data.Title,
                Description = data.Description,
                Cid = data.Cid,
                Date = data.Date,
                Category = CategoryConverter(data.Category)
            };
            return news;
        }

        private static News NewsConverter(NewsDTO data)
        {
            var news = new News()
            {
                Id = data.Id,
                Title = data.Title,
                Description = data.Description,
                Cid = data.Cid,
                Date = data.Date,
            };
            return news;
        }

        private static CategoryDTO CategoryConverter(Category category)
        {
            return new CategoryDTO()
            {
                Id = category.Id,
                Name = category.Name,
            };
        }
    }
}