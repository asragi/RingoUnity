using System.Collections.Generic;
using System.Threading.Tasks;
using RingoLib.Authorization.SignUp.Repositories;
using RingoLib.Authorization.SignUp.Repositories.Helper;
using RingoLib.Core.Error;

namespace RingoLib.Authorization.SignUp.Infrastructures.InMemory
{
	public class UserAuthRepositoryInMemory : IUserAuthRepository
	{
        private readonly Dictionary<string, User> _dict;
		public UserAuthRepositoryInMemory()
		{
            _dict = new();
		}

        public Task<PostSignUpRepoResponse> PostSignUpAsync(string userId, string userName, string loginKey)
        {
            string authToken = CreateAuthToken(loginKey);
            _dict.Add(userId, new(userId, userName, loginKey, authToken));
            return new(() => new(userName, userId, authToken, NoError.It));
        }

        private string CreateAuthToken(string key) => key + key;

        private readonly struct User {
            public string UserId { get; }
            public string UserName { get; }
            public string LoginKey { get; }
            public string AuthToken { get; }
	        
            public User(string userId, string userName, string loginKey, string authToken) {
                UserId = userId;
                UserName = userName;
                LoginKey = loginKey;
                AuthToken = authToken;
	        }
	    }
    }

}
