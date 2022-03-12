using BookLibrary.Core.Models.Books;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(AddBookFormModel book)
        {
            return View();
        }


    }
}
