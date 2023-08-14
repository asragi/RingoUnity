namespace RingoLib.Authorization.SignUp.Services.Helper
{
	public readonly struct PostSignUpRequest
	{
		public PostSignUpRequest(
            string userName,
            string userId,
			string loginKey)
		{

			UserName = userName;
			UserId = userId;
			LoginKey = loginKey;
		}

		internal string UserName { get; }
		internal string UserId { get; }
		internal string LoginKey { get; }
	}
}
