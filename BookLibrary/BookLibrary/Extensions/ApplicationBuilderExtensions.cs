using System.Linq;
using BookLibrary.Data;
using BookLibrary.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookLibrary.Extensions
{

    public static class ApplicationBuilderExtensions
    {

        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var services = scopedServices.ServiceProvider;


            // var data = //scopedServices.ServiceProvider.GetService<BookLibraryDbConte//xt>();
            //
            // data.Database.Migrate();

            SeedCategories(services);

            return app;
        }

        private static void MigrateDatabase(IServiceProvider services)
        {

            var data = services.GetRequiredService<BookLibraryDbContext>();

            data.Database.Migrate();
        }

        private static void SeedCategories(IServiceProvider services)
        {
            var data = services.GetRequiredService<BookLibraryDbContext>();

            if (data.Categories.Any())
            {
                return;
            }

            data.Categories.AddRange(new[]
            {
              new Category { Name = "Literary Fiction" },
              new Category { Name = "Horror" },
              new Category { Name = "Historical Fiction" },
              new Category { Name = "Fantasy" },
              new Category { Name = "Detective and Mystery" },
              new Category { Name = "Comic Book or Graphic Novel" },
              new Category { Name = "Classics" },
              new Category { Name = "Action and Adventure" },
          });

            data.SaveChanges();
        }
    }

}
