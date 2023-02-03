using System.Net;

namespace BlogApi.Endpoints
{
	public class APIResponse<T> where T : class
	{
		public APIResponse()
		{
			ErrorMessages = new List<string>();
		}
		public bool IsSuccess { get; set; }
		public ICollection<T> Result { get; set; } = null!;
		public HttpStatusCode StatusCode { get; set; }
		public List<string> ErrorMessages { get; set; }

	}
}
