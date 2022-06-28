using BookStoreApplication.Models;
using BookStoreApplication.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStoreApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRespository bookRespository = null;
       
        public BookController()
        {
            bookRespository =new BookRespository();
        }

        public ViewResult   GetAllBooks()
        {
            var data = bookRespository.GetAllBooks();

            return View();
        }
 
        public BookModel GetBook(int id)
        {
            return bookRespository.GetBooksById(id);
        }

        public List<BookModel> SearchBooks(string bookName, string authorName)
        {
            return bookRespository.SearchBook(bookName, authorName); 
        }
    }
}
