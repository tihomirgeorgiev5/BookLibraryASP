using BookLibrary.Core.Models.Books;
using BookLibrary.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookLibraryDbContext data;

        public BooksController(BookLibraryDbContext data)
        {
            this.data = data;

        }
        public IActionResult Add() => View(new AddBookFormModel
        {
            Categories = this.GetBookCategories()

        });

        [HttpPost]
        public IActionResult Add(AddBookFormModel book)
        {
            return View();
        }

        private IEnumerable<BookCategoryViewModel> GetBookCategories()
            => this.data
                   .Categories
            .Select(c => new BookCategoryViewModel
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToList();
       
    }
}
