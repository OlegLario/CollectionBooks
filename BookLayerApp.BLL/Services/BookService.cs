using BookLayerApp.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookLayerApp.DAL.Interfaces;
using BookLayerApp.DAL.Entities;
using BookLayerApp.BLL.DTO;
using AutoMapper;

namespace BookLayerApp.BLL.Services
{
    public class BookService //: IBookSearchService, IBookCreateService 
    {
        IRepository Db;
        public BookService(IRepository repo)
        {
            Db = repo;
        }
    }
}
