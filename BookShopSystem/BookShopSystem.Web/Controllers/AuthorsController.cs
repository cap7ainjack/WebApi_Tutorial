using BookShopSystem.Services;
using BookShopSystem.Services.Contracts;
using BookShopSytem.Models.VmModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BookShopSystem.Web.Controllers
{
    [RoutePrefix("api/authors")]
    public class AuthorsController : ApiController
    {
        private IAuthorsService service;

        public AuthorsController()
        {
            this.service = new AuthorsService();
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            if (!this.service.ContainsAuthor(id))
            {
                return NotFound();
            }

            DetailedAuthorVM author = this.service.GetDetailedAuthor(id);
            return Ok(author);
        }
    }
}