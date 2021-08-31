using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineNotes.Models {
    public class Vineyard {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Climat { get; set; } = null;
    }
}
