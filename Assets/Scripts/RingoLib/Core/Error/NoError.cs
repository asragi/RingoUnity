namespace RingoLib.Core.Error
{
	public class NoError : IRError {
        public static NoError It { get; } = new();
        public string Message => string.Empty;
    }
}
