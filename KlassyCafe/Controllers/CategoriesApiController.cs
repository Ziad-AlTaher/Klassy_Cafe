using KlassyCafe.Models;
using KlassyCafe.NewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KlassyCafe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesApiController : ControllerBase
    {
        ICategoryService CatService;

        public CategoriesApiController(ICategoryService categoryService)
        {
            CatService = categoryService;
        }
        // GET: api/<CategoriesApiController>
        [HttpGet]
        public IEnumerable<TbCategory> Get()
        {
            List <TbCategory> CatApi = CatService.GetAll();
            return CatApi;
        }

        // GET api/<CategoriesApiController>/5
        [HttpGet("{id}" , Name ="GetCategory")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoriesApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CategoriesApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriesApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
