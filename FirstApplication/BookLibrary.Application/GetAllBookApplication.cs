using BookLibrary.Application.Models;

namespace BookLibrary.Application
{
	public class GetAllBookApplication : IGetAllBooks
	{
		#region Public methods
		public IList<Book> GetAll(string? query)
		{
			List<Book> data = new List<Book>()
			{
				new() { Description = "Dune est super", Title = "Dune"},
				new() { Description = "La stratégie Ender est super bien", Title = "La stratégie Ender"},
			};

			if (!string.IsNullOrEmpty(query))
			{
				data = data.Where(item => item.Title.ToLower().Contains(query)).ToList();
			}

			return data;
		}
		#endregion
	}
}
