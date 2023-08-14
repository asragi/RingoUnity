using System.Threading.Tasks;
using RingoLib.Authorization.SignUp.Repositories.Helper;

namespace RingoLib.Authorization.SignUp.Repositories {
	public interface IUserAuthRepository
	{
		Task<PostSignUpRepoResponse> PostSignUpAsync(
            string userId,
            string userName,
            string loginKey,
            string appKey);
	}
}
