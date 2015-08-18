using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using junkiesApi.Models;
using junkiesApi.Repos;

namespace junkiesApi.Controllers
{
    [Route("api/[controller]")]
    public class ShipController : Controller
    {
        private readonly JunkiesDbContext _dbContext;

        public ShipController(JunkiesDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        // GET: api/Ship
        [HttpGet]
        public IEnumerable<Ship> Get()
        {
            return _dbContext.Ships;
        }

        // GET api/Ship/5
        [HttpGet("{id}", Name = "GetShipByIdRoute")]
        public IActionResult Get(int id)
        {
            var item = _dbContext.Ships.FirstOrDefault(m => m.Id == id);
            if (item == null)
            {
                return new HttpNotFoundResult();
            }
            else
            {
                return new ObjectResult(item);
            }
        }

        // POST api/Ship
        [HttpPost]
        public IActionResult Post([FromBody] Ship item)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                _dbContext.Ships.Add(item);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Get");
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _dbContext.Ships.FirstOrDefault(m => m.Id == id);
            _dbContext.Ships.Remove(item);
            _dbContext.SaveChanges();
            return new HttpStatusCodeResult(200);
        }
    }
}
