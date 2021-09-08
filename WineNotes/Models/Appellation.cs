using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineNotes.Models {
    public class Appellation {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public Region Region { get; set; } = null;
        public Cru Cru { get; set; } = Cru.None;
    }

    public enum Cru { Premier=1, Grand=2, None=0 }

    public class Region {
        public int Id { get; set; }
        public string Name { get; set; }
        public Village Village { get; set; } = null;
    }

    public class Village {
        public int Id { get; set; }
        public string Name { get; set; }
        public Vineyard Vineyard { get; set; } = null;
    }

    public class Vineyard {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Climat { get; set; } = null;
    }
}
