using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineNotes.Models {
    public class Note {

        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public Appearance Appearance { get; set; }
        public Aroma Aroma { get; set; }
        public Taste Taste { get; set; }
        public Quality Quality { get; set; }
    }

    public class Appearance {
        public int Id { get; set; }

    }

    public class Aroma {
        public int Id { get; set; }

    }

    public class Taste {
        public int Id { get; set; }

    }

    public class Quality {
        public int Id { get; set; }

    }
}
