using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Farkle.Garage.Controllers
{
    [Route("api/[controller]")]
    public class GarageController : Controller
    {
        // GET api/garage
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        // POST api/garage
        [HttpPost]
        public void Post([FromBody]string title)
        {

        }
    }
}
