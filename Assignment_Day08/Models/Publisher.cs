using System;
using System.Collections.Generic;

namespace Assignment_Day08.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
