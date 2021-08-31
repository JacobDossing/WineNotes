using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineNotes.Controllers {

    [Route("api")]
    public class HomeController : ControllerBase{

        [HttpGet]
        public string Index() {

            int now = DateTime.Now.Hour;

            string politeness = now > 5 && now < 10 ? "morning" : now > 9 && now < 15 ? "day" :
                now > 14 && now < 18 ? "afternoon" : now > 17 && now <= 23 ? "evening" : "night";           

            return $"Good{politeness} sir. How may I be at service today?";
        }
    }
}
