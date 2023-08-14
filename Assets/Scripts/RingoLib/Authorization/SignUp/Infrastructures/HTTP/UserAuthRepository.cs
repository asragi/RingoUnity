using System;
using System.Net.Http;
using System.Threading.Tasks;
using RingoLib.Authorization.SignUp.Repositories;
using RingoLib.Authorization.SignUp.Repositories.Helper;
using RLib.HTTP;
using RLib.Utils;

namespace RingoLib.Authorization.SignUp.Infrastructures.HTTP
{
	public class UserAuthRepository : IUserAuthRepository
	{
		private static readonly string Path = "signup";
		private static readonly string APIPath = Const.APIURL() + Path;
		private readonly HTTPService _httpService;
		private readonly HttpClient _client;
		private readonly IRJson _json;

		public UserAuthRepository(HttpClient client, IRJson json)
		{
			_httpService = new();
			_client = client;
			_json = json;
		}

		public async Task<PostSignUpRepoResponse> PostSignUpAsync(
            string userId,
            string userName,
            string loginKey,
            string appKey)
		{
			PostRequest req = new(userId, userName, loginKey, appKey);
			string jsonText = _json.ToJson(req);
			var responseText = await _httpService.PostJsonAsync(_client, jsonText, APIPath);
			var res = _json.FromJson<PostSignUpRepoResponse>(responseText);
			return res;
		}

		[Serializable]
		private class PostRequest {
			public string userId;
			public string userName;
			public string loginKey;
			public string appKey;

			public PostRequest(string id, string name, string loginKey, string appKey) {
				userId = id;
				userName = name;
				this.loginKey = loginKey;
				this.appKey = appKey;
			}
		}
	}
}
