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
    public class ItmesApiController : ControllerBase
    {
        IitemService ItemS;

        public ItmesApiController(IitemService iitemService)
        {
            ItemS = iitemService;
        }
        // GET: api/<ItmesApiController>
        [HttpGet]
        public IEnumerable<VwItemCategory> Get()
        {
            return ItemS.GetAllItemsWithCats();
        }

        // GET api/<ItmesApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ItmesApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ItmesApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItmesApiController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
