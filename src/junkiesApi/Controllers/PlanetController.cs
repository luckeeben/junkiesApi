using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using junkiesApi.Models;
using junkiesApi.Repos;

namespace junkiesApi.Controllers
{
    [Route("api/[controller]")]
    public class PlanetController : Controller
    {
        private readonly JunkiesDbContext _dbContext;

        public PlanetController(JunkiesDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        // GET: api/Planet
        [HttpGet]
        public IEnumerable<Planet> Get()
        {
            return _dbContext.Planets;
        }

        // GET api/Planet/5
        [HttpGet("{id}", Name = "GetPlanetByIdRoute")]
        public IActionResult Get(int id)
        {
            var item = _dbContext.Planets.FirstOrDefault(m => m.Id == id);
            if (item == null)
            {
                return new HttpNotFoundResult();
            }
            else
            {
                return new ObjectResult(item);
            }
        }

        // POST api/Planet
        [HttpPost]
        public IActionResult CreatePlanet([FromBody] Planet item)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                _dbContext.Planets.Add(item);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Get");
        }

        //// PUT api/Planet/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/Planet/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _dbContext.Planets.FirstOrDefault(m => m.Id == id);
            _dbContext.Planets.Remove(item);
            _dbContext.SaveChanges();
            return new HttpStatusCodeResult(200);
        }
    }
}
