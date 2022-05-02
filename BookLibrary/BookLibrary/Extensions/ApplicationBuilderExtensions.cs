using BookLibrary.Data;
using BookLibrary.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Extensions
{

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<BookLibraryDbContext>();

            data.Database.Migrate();

            SeedCategories(data);

            return app;
        }

        private static void SeedCategories(BookLibraryDbContext data)
        {
            if (data.Categories.Any())
            {
                return;
            }

            data.Categories.AddRange(new[]
            {
                new Category { Name = "All"},
                new Category { Name = "Action and Adventure"},
                new Category { Name = "Classics"},
                new Category { Name = "Comic Book or Graphic Novel"},
                new Category { Name = "Detective and Mystery"},
                new Category { Name = "Fantasy"},
                new Category { Name = "Action and Adventure"},
                new Category { Name = "Historical Fiction"},
                new Category { Name = "Horror"},
                new Category { Name = "Literary"},
            });

            data.SaveChanges();
        }
    }
}
