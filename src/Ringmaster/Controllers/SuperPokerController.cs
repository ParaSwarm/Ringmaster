using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Ringmaster.Models;
using Ringmaster.Service;

namespace Ringmaster.Controllers
{
    [Route("api/[controller]")]
    public class SuperPokerController : Controller
    {
        private SuperPokerService SuperPokerService { get; set; }

        public SuperPokerController(SuperPokerService superPokerService)
        {
            this.SuperPokerService = superPokerService;
        }

        [HttpGet]
        public SuperPokerDeck Get()
        {
            this.SuperPokerService.AddPlayer(this.Request.Host.Value);

            return this.SuperPokerService.GameStart();
        }
    }
}
