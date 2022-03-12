namespace BookLibrary.Core.Models.Books
{
    
    public class AddBookFormModel
    {
        public string Title { get; init; }

        public string Author { get; init; }


        public string ImageUrl { get; init; }

        public string Description { get; init; }

        public int Year { get; init; }

        public int CategoryId { get; init; }

    }
}
