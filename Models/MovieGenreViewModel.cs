using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Security.Permissions;

namespace MVCApp.Models
{
	public class MovieGenreViewModel
	{
		//signo de ? puede o no que tenga datos nuestra lista
		public List<Movie>? Movies { get; set; }
		public SelectList? Genres { get; set; }
		public string? MovieGenre { get; set; }
		public string? SearchString { get; set; }


	}
}
