using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Ringmaster.Controllers
{
    [Route("api/[controller]")]
    public class SuperPokerController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
