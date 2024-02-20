namespace BookLibrary.Application.Models
{
	public class Book
	{
		#region Properties
		public int Id { get; set; }

		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		#endregion
	}
}
