using BookLibrary.Application.Models;

namespace BookLibrary.Application
{
	public interface IGetAllBooks
	{
		IList<Book> GetAll(string? query);
	}
}
