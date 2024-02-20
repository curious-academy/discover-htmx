using BookLibrary.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstApplication.Pages
{
	public class BooksListModel : PageModel
	{
		#region Fields
		private readonly IGetAllBooks application;
		#endregion

		#region Constructors
		public BooksListModel(IGetAllBooks application)
		{
			this.application = application;
		}
		#endregion

		#region Public methods
		public void OnGet()
		{
		}

		public async Task<IActionResult> OnGetLoadBooks(string query)
		{
			await Task.Delay(500);

			return Partial("_ListBooks", this.application.GetAll(query));
		}
		#endregion
	}
}
