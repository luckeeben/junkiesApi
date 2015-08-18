using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using junkiesApi.Models;

namespace junkiesApi.Controllers
{
    [Route("api/[controller]")]
    public class SectorController : Controller
    {
        private readonly JunkiesDbContext _dbContext;

        public SectorController(JunkiesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Sector
        [HttpGet]
        public IEnumerable<Sector> Get()
        {
            return _dbContext.Sectors;
        }

        // GET api/Sector/5
        [HttpGet("{id}", Name = "GetSectorByIdRoute")]
        public IActionResult Get(int id)
        {
            var item = _dbContext.Sectors.FirstOrDefault(m => m.Id == id);
            if (item == null)
            {
                return new HttpNotFoundResult();
            }
            else
            {
                return new ObjectResult(item);
            }
        }

        // GET api/Sector/5/Warps
        [HttpGet("{sectorid}/Warps")]
        public IActionResult GetSectorWarps(int sectorid)
        {
            var sectorwarps = _dbContext.SectorWarps.Where(m => m.SectorId == sectorid);
            if (sectorwarps == null)
            {
                return new HttpNotFoundResult();
            }
            else
            {
                List<int> warplist = new List<int>();
                foreach (SectorWarp sectorwarp in sectorwarps)
                {
                    warplist.Add(sectorwarp.WarpId);
                }

                return new ObjectResult(warplist);
            }
        }

        // POST api/Sector
        [HttpPost]
        public IActionResult CreateSector([FromBody] Sector item)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                _dbContext.Sectors.Add(item);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Get");
        }

        //POST api/Sector/SetWarp/5/43
        [HttpPost("{sectorId}/SetWarp/{warpId}")]
        public IActionResult SetWarp(int sectorId, int warpId)
        {
            var item = new SectorWarp()
                {
                    Id = 0,
                    SectorId = sectorId ,
                    WarpId = warpId
                };
            _dbContext.SectorWarps.Add(item);
            _dbContext.SaveChanges();

            return RedirectToAction("Get");

        }

        // DELETE api/Sector/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _dbContext.Sectors.FirstOrDefault(m => m.Id == id);
            _dbContext.Sectors.Remove(item);
            _dbContext.SaveChanges();
            return new HttpStatusCodeResult(200);
        }
    }
}
