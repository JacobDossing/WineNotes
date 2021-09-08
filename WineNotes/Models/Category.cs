using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineNotes.Models {
    public class Category {

        public int Id { get; set; }
        public WineType Type { get; set; }
        public ICollection<Colour> Colours { get; set; }
    }

    public enum WineType {
        Red, Rose, White, Fortified, Dessert, Sparkling, Other
    }
}
