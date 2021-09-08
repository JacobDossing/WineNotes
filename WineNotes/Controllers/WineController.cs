using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WineNotes.Models;

namespace WineNotes.Controllers {

    [Route("api/[controller]")]
    public class WineController : ControllerBase {

        [HttpPost]
        public void AddNote(Wine wine, Note note) {

        }

        [HttpGet]
        public Note GetNote(Wine wine) {
            return new Note();
        }
    }
}
