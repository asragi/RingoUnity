using RingoLib.Core.Models;

namespace RingoLib.Search.SearchAction.Services.Helpers
{
	public readonly struct GetStageListResponse
	{
		public GetStageListResponse(
			StageState[] stages
	    )
		{
			Stages = stages;
		}

		public StageState[] Stages { get; }
	}
}
