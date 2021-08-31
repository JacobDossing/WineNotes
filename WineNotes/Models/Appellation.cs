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

    public enum Cru { Premier, Grand, None }
}
