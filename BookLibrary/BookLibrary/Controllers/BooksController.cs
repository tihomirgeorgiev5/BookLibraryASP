using BookLibrary.Infrastructure.Data.Models;
using BookLibrary.Core.Models.Books;
using BookLibrary.Data;
using Microsoft.AspNetCore.Mvc;



 namespace BookLibrary.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookLibraryDbContext data;

        public BooksController(BookLibraryDbContext data)
       
           => this.data = data;

        
        public IActionResult Add() => View(new AddBookFormModel
        {
            Categories = this.GetBookCategories()

        });

        [HttpPost]
        public IActionResult Add(AddBookFormModel book)
        {
            if (!this.data.Categories.Any(c => c.Id == book.CategoryId))
            {
                this.ModelState.AddModelError(nameof(book.CategoryId), "category does not exist.");
            }
            if (!ModelState.IsValid)
            {
                book.Categories = this.GetBookCategories();
                return View(book);
            }

            var bookData = new Book()
            {
                Title = book.Title,
                Author = book.Author,
                Description = book.Description,
                ImageUrl = book.ImageUrl,
                Publisher = book.Publisher,
                Year = book.Year,
                CategoryId = book.CategoryId
            };

            this.data.Books.Add(bookData);

            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
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

