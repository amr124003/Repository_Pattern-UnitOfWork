﻿using System.ComponentModel.DataAnnotations;

namespace RepositoryPattern.Core.Models
{
	public class Author
	{
		public int Id { get; set; }
		[Required, MaxLength(20)]
		public string? Name { get; set; }

		public virtual ICollection<Book>? Books { get; set; }
	}
}
