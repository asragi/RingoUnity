using System.Threading.Tasks;
using RingoLib.Search.SearchAction.Repositories;
using RingoLib.Search.SearchAction.Services.Helpers;

namespace RingoLib.Search.SearchAction.Services
{
	public class GetStageService
	{
		private readonly IUserStageRepository _stageRepo;

		public GetStageService(IUserStageRepository stageRepo)
		{
			_stageRepo = stageRepo;
		}

		public async Task<GetStageListResponse> GetStageList(GetStageListRequest req) {

			UnityEngine.Debug.Log("GetStage");
			var response = await _stageRepo.GetStageList(new(req.UserId));
			UnityEngine.Debug.Log("GetStageResponse");
			
			return new(response.Stages);
		}

		public async Task<GetDetailResponse> GetDetail(GetDetailRequest req) {
			var response = await _stageRepo.GetStageDetail(req.UserId, req.StageId);
			return new();
		}
	}
}
