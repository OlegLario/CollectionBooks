using BookLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLayerApp.DAL.Interfaces
{
    public interface IRepository 
    {
        //List<Book> GetAllBooks();
        void Create(Book item);
        void Save();
        Book SearchAll(string searchString);
    }
}
