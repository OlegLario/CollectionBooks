using BookLayerApp.DAL.EF;
using BookLayerApp.DAL.Entities;
using BookLayerApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLayerApp.DAL.Repositories
{
    public class BookRepository : IRepository
    {
        private BookContext db;
        public BookRepository() { }

        public BookRepository(BookContext item)
        {
            db = item;
        }
        /*public List<Book> GetAllBooks()
        {
            return db.Books.ToList();
        }*/
        public void Create(Book item)
        {
            db.Books.Add(item);
            db.SaveChanges();
        }
        public void Save()
        {
            db.SaveChanges();
        }
        
        public Book SearchAll(string searchString)
        {
            Book books;
            var book = db.Books.Where(b => (b.Id.ToString() != null && b.Id.ToString().Contains(searchString.ToLower())) || (b.Author != null && b.Author.ToLower().Contains(searchString.ToLower()))
            || (b.Title != null && b.Title.ToLower().Contains(searchString.ToLower())) || (b.EditionDate.ToString() != null && b.EditionDate.ToString().Contains(searchString.ToLower())));


            /*var books = from b in db.Books
                        select b;      
            if (!String.IsNullOrEmpty(searchString))
            {
                int id = int.Parse(searchString);
                books = books.Where(x => x.Id == id);
            }
            if (!String.IsNullOrEmpty(searchString))
                books = books.Where(x => x.Author.Contains(searchString));
            if (!String.IsNullOrEmpty(searchString))
                books = books.Where(x => x.Title.Contains(searchString));
            if (!String.IsNullOrEmpty(searchString)){
                DateTime searchDate;
                if(DateTime.TryParse(searchString, out searchDate))
                {
                    books = books.Where(x => x.EditionDate == searchDate);
                }
            }*/
            books = (Book)book;
            return books;
        }



    }
}
