using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fuela_clients.Models;
using Fuela_clients.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fuela_clients.Controllers
{
    public class BookController : Controller
    {
        private readonly Booksrepository _Booksrepository = null;

       public  BookController()
        {
            _Booksrepository = new Booksrepository();

        }
        public ViewResult GetAllBooks()
        {
            var data= _Booksrepository.GetAllBooks();
            return View(data);
        }
        public ViewResult GetBook(int id)
        {
            var data = _Booksrepository.GetBookById(id);
            return View(data);
        }
         public List<BooksModel>  searchbook(string bookname,string authorname)
        {
           return _Booksrepository.SearchBooks(bookname,authorname);
        }
       
        public ViewResult AddNewBook()
        {
            return View();
        }
    }
}