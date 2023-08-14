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
		private readonly string _apiURL;
		private readonly HTTPService _httpService;
		private readonly HttpClient _client;
		private readonly IRJson _json;

		public UserAuthRepository(HttpClient client, IRJson json, string apiURL)
		{
			_httpService = new();
			_client = client;
			_json = json;
			_apiURL = apiURL;
		}

		private string APIPath => _apiURL + Path;

		public async Task<PostSignUpRepoResponse> PostSignUpAsync(
            string userId,
            string userName,
            string loginKey)
		{
			PostRequest req = new(userId, userName, loginKey);
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

			public PostRequest(string id, string name, string loginKey) {
				userId = id;
				userName = name;
				this.loginKey = loginKey;
			}
		}
	}
}
