using RingoLib.Core.Error;

namespace RingoLib.Authorization.SignUp.Services.Helper
{
	public readonly struct PostSignUpResponse
	{
		public PostSignUpResponse(string userName, string userId, IRError err)
		{
			UserName = userName;
			UserId = userId;
			Error = err;
		}

		public string UserName { get; }
		public string UserId { get; }
		public IRError Error { get; }
	}
}
