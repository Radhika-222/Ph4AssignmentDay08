using System;
using System.Collections.Generic;

namespace Assignment_Day08.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string? BookName { get; set; }
        public double? Price { get; set; }
        public int? CategoryId { get; set; }
        public int? PublisherId { get; set; }

        public virtual BookCategory? Category { get; set; }
        public virtual Publisher? Publisher { get; set; }
    }
}
