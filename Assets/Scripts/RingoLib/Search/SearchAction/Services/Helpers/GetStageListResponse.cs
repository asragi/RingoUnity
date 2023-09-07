using RingoLib.Search.SearchAction.Repositories.DTO;

namespace RingoLib.Search.SearchAction.Services.Helpers
{
	public readonly struct GetStageListResponse
	{
		public GetStageListResponse(
			StageInformation[] stages
	    )
		{
			Stages = stages;
		}

		public StageInformation[] Stages { get; }
	}
}
