using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stalwart.Models;
using Stalwart.Repository;

namespace Stalwart.Controllers
{
    public class BookController : Controller
    {
        [ViewData]
        public string Name { get; set; }
        public int Age { get; set; }

        private readonly BookRepository bookRepository = null;

        public BookController(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public ViewResult GetAllBooks()
        {
            Name = "Phils";
            var data = bookRepository.GetAllBooks();
            ViewBag.datas = data;
            return View();
        }

        public ViewResult GetBook(int id)
        {
            var data = bookRepository.GetBookById(id);
            return View(data);
        }
        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return bookRepository.SearchBook(bookName,authorName);  
        }
    }
}
