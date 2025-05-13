using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Core.Models
{
	public class Book
	{
		public int Id { get; set; }
		[Required, MaxLength(20)]
		public string? Title { get; set; }

		public virtual ICollection<Author>? Author { get; set; }
	}
}
