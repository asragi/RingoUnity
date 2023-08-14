namespace RingoLib.Authorization.SignUp.Services.Helper
{
	public readonly struct PostSignUpRequest
	{
		public PostSignUpRequest(
            string userName,
            string userId,
			string loginKey,
            string appKey)
		{

			UserName = userName;
			UserId = userId;
			LoginKey = loginKey;
			ApplicationKey = appKey;
		}

		internal string UserName { get; }
		internal string UserId { get; }
		internal string LoginKey { get; }
		internal string ApplicationKey { get; }
	}
}
