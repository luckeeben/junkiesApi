using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using junkiesApi.Models;
using junkiesApi.Repos;

namespace junkiesApi.Controllers
{
    [Route("api/[controller]")]
    public class QuadrantController : Controller
    {
        private readonly JunkiesDbContext _dbContext;

        public QuadrantController(JunkiesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Quadrant
        [HttpGet]
        public IEnumerable<Quadrant> Get()
        {
            return _dbContext.Quadrants;
        }

        // GET api/Quadrant/5
        [HttpGet("{id}", Name = "GetQuadrantByIdRoute")]
        public IActionResult Get(int id)
        {
            var item = _dbContext.Quadrants.FirstOrDefault(m => m.Id == id);
            if (item == null)
            {
                return new HttpNotFoundResult();
            }
            else
            {
                return new ObjectResult(item);
            }
        }

        // POST api/Quadrant
        [HttpPost]
        public IActionResult CreateQuadrant([FromBody] Quadrant item)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                _dbContext.Quadrants.Add(item);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Get");
        }

        //// PUT api/Quadrant/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        // DELETE api/Quadrant/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _dbContext.Quadrants.FirstOrDefault(m => m.Id == id);
            _dbContext.Quadrants.Remove(item);
            _dbContext.SaveChanges();
            return new HttpStatusCodeResult(200);
        }
    }
}
