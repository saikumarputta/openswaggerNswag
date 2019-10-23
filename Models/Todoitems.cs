using System;
using System.Collections.Generic;

namespace openswaggerNswag.Models
{
    public partial class Todoitems
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public short IsComplete { get; set; }
        public string Rating { get; set; }
    }
}
