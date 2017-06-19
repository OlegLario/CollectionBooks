using BookLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLayerApp.DAL.EF
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public BookContext() : base("DefaultConnection") { }
        public BookContext(string connectionString)
            : base(connectionString) { }
    }
}
