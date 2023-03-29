using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseAceesLayer.Models;

namespace DatabaseAceesLayer.Repo
{
    public class NewsRepository
    {
        private static readonly NewDBContext Context;

        static NewsRepository()
        {
            Context = new NewDBContext();
        }

        public static IEnumerable<News> GetAllNews()
        {
            return Context.News.ToList();
        }

        public static News GetNewsById(int id)
        {
            return Context.News.Find(id);
        }

        public static bool AddNews(News news)
        {
            Context.News.Add(news);
            return Context.SaveChanges() > 0;
        }

        public static bool UpdateNews(News news)
        {
            var dbnews = Context.News.Find(news.Id);
            Context.Entry(dbnews).CurrentValues.SetValues(news);
            return Context.SaveChanges() > 0;
        }

        public static bool DeleteNews(int id)
        {
            var news = Context.News.Find(id);
            Context.News.Remove(news);
            return Context.SaveChanges() > 0;
        }

        public static IEnumerable<News> GetNewsByCategoryName(string name)
        {
            return Context.News.Where(x => x.Category.Name == name).ToList();
        }

        public static IEnumerable<News> GetNewsByDate(DateTime date)
        {
            //This is to make sure that user get the news of the day he/she is looking for ingore the time
            var startDate = date.Date; // extract only the date part of the datetime
            var endDate = startDate.AddDays(1); // add one day to get the end date

            return Context.News.Where(x => x.Date >= startDate && x.Date < endDate).ToList();
        }

        public static IEnumerable<News> GetNewsByCategoryAndDate(string name, DateTime date)
        {
            //This is to make sure that user get the news of the day he/she is looking for ingore the time
            var startDate = date.Date; // extract only the date part of the datetime
            var endDate = startDate.AddDays(1); // add one day to get the end date

            return Context.News.Where(x => x.Date >= startDate && x.Date < endDate && x.Category.Name == name).ToList();
        }


        public static News GetNewById(int id)
        {
            return Context.News.Find(id);
        }
    }
}