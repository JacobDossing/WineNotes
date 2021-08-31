using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineNotes.Models {
    public class Village {

        public int Id { get; set; }
        public string Name { get; set; }
        public Vineyard Vineyard { get; set; } = null;
    }
}
