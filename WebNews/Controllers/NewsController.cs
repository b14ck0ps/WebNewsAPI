using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BussinessLogicLayer.DTOs;
using BussinessLogicLayer.Services;

namespace WebNews.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class NewsController : ApiController
    {
        [HttpGet]
        [Route("api/news")]
        public HttpResponseMessage GetAllNews()
        {
            try
            {
                var data = NewsService.GetAllNews();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/news/{id}")]
        public HttpResponseMessage GetNewsById(int id)
        {
            try
            {
                var data = NewsService.GetNewById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/news/category/{name}")]
        public HttpResponseMessage GetNewsByCategoryName(string name)
        {
            try
            {
                var data = NewsService.GetNewsByCategoryName(name);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/news/date/{date}")]
        public HttpResponseMessage GetNewsByDate(DateTime date)
        {
            try
            {
                var data = NewsService.GetNewsByDate(date);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/news/category/{name}/date/{date}")]
        public HttpResponseMessage GetNewsByCategoryAndDate(string name, DateTime date)
        {
            try
            {
                var data = NewsService.GetNewsByCategoryAndDate(name, date);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/news")]
        public HttpResponseMessage AddNews([FromBody] NewsDTO news)
        {
            try
            {
                var data = NewsService.AddNews(news);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPatch]
        [Route("api/news/update")]
        public HttpResponseMessage UpdateNews([FromBody] NewsDTO news)
        {
            try
            {
                var data = NewsService.UpdateNews(news);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/news/{id}")]
        public HttpResponseMessage DeleteNews(int id)
        {
            try
            {
                var data = NewsService.DeleteNews(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}