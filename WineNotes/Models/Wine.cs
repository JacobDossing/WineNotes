using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineNotes.Models {
    public class Wine {

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Note> Notes { get; set;}
    }
}
