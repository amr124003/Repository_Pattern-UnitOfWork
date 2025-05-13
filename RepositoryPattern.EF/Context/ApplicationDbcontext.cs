using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Models;

namespace RepositoryPattern.EF.Context
{
	public class ApplicationDbcontext : DbContext
	{
		public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Author>(x =>
			{
				x.HasData
				(
					new Author()
					{
						Id = 1,
						Name = "Ahmed",
					},
					new Author()
					{
						Id = 2,
						Name = "Ziad",
					},
					new Author()
					{
						Id = 3,
						Name = "Khalid",
					},
					new Author()
					{
						Id = 4,
						Name = "Mohamed",
					}
				);
			});

			modelBuilder.Entity<Book>(x =>
			{
				x.HasData
				(
					new Book()
					{
						Id = 1,
						Title = "Title1"
					},
					new Book()
					{
						Id = 2,
						Title = "Title2"
					},
					new Book()
					{
						Id = 3,
						Title = "Title3"
					},
					new Book()
					{
						Id = 4,
						Title = "Title4"
					}
				);
			});
		}

		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
	}
}
