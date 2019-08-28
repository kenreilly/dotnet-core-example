using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ItemsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        static private List<Item> items = new List<Item>();

        // GET api/values
        [HttpGet]
        public ActionResult<List<Item>> Get()
        {
            return items;
        }

        // GET api/values/5
        [HttpGet("{index}")]
        public ActionResult<Item> Get(int index)
        {
            return items[index];
        }

        // GET api/values/5
        [HttpGet("/range/{a}/to/{b}")]
        public ActionResult<List<Item>> Get(int a, int b)
        {
            return items.GetRange(a, b - a);
        }

        // POST api/values
        [HttpPost]
        public int Post([FromBody] Item item)
        {
            ItemsController.items.Add(item);
            int index = ItemsController.items.Count() - 1;
            return index;
        }

        // PUT api/values/5
        [HttpPut("{index}")]
        public void Put(int id, [FromBody] Item item)
        {
            ItemsController.items[id] = item;
        }

        // DELETE api/values/5
        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            ItemsController.items.RemoveAt(index);
        }
    }
}