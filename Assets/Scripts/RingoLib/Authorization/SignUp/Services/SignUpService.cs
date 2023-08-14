using System.Threading.Tasks;
using RingoLib.Authorization.SignUp.Repositories;
using RingoLib.Authorization.SignUp.Services.Helper;

namespace RingoLib.Authorization.SignUp.Services
{
	public class SignUpService
	{
		private readonly IUserAuthRepository _userAuthRepo;

		public SignUpService(IUserAuthRepository userAuthRepo) {
			_userAuthRepo = userAuthRepo;
		}

		public async Task<PostSignUpResponse> PostSignUpAsync(
			PostSignUpRequest request
	    ){
			var userId = request.UserId;
			var userName = request.UserName;
			var response = await _userAuthRepo.PostSignUpAsync(
				userId,
				userName,
				request.LoginKey,
				request.ApplicationKey
			);
			return new(response.UserId, response.UserName, response.Error);
		}
	}
}
