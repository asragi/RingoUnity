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

		internal string UserName { get; }
		internal string UserId { get; }
		internal IRError Error { get; }
	}
}

