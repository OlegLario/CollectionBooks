using BookLayerApp.BLL.DTO;
using BookLayerApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLayerApp.BLL.Interfaces
{
    public interface IBookCreateService
    {
        BookDTO Create(BookDTO item);
        void Save();
    }
}
