using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionBooks.Models
{
    public class BookView
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime EditionDate { get; set; }
    }
}