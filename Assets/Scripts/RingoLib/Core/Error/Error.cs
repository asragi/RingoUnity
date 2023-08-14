namespace RingoLib.Core.Error
{
	public class Error : IRError
	{
		public Error(string message, IRError innerError)
		{
			Message = message;
		}

		public string Message { get; }
	}
}
