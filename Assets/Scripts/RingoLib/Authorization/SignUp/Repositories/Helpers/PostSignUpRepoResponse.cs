using RingoLib.Core.Error;

namespace RingoLib.Authorization.SignUp.Repositories.Helper
{
	public readonly struct PostSignUpRepoResponse
	{
		public PostSignUpRepoResponse(
	    string userName, string userId, string userToken, IRError err)
		{
			UserName = userName;
			UserId = userId;
			UserToken = userToken;
			Error = err;
		}

		internal string UserName { get; }
		internal string UserId { get; }
		internal string UserToken { get; }
		internal IRError Error { get; }
	}
}
