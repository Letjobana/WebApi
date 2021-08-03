using System;

namespace my_books.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public string IsRead { get; set; }
        public DateTime? DataRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
