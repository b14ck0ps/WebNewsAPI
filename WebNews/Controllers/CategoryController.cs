using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BussinessLogicLayer.DTOs;
using BussinessLogicLayer.Services;

namespace WebNews.Controllers
{
    public class CategoryController : ApiController
    {
        [HttpGet]
        [Route("api/category")]
        public HttpResponseMessage GetAllCategories()
        {
            try
            {
                var data = CategoryService.GetAllCategories();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/category/{id}")]
        public HttpResponseMessage GetCategoryById(int id)
        {
            try
            {
                var data = CategoryService.GetCategoryById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/category")]
        public HttpResponseMessage AddCategory([FromBody] CategoryDTO category)
        {
            try
            {
                var data = CategoryService.AddCategory(category);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPatch]
        [Route("api/category")]
        public HttpResponseMessage UpdateCategory([FromBody] CategoryDTO category)
        {
            try
            {
                var data = CategoryService.UpdateCategory(category);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/category/{id}")]
        public HttpResponseMessage DeleteCategory(int id)
        {
            try
            {
                var data = CategoryService.DeleteCategory(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}