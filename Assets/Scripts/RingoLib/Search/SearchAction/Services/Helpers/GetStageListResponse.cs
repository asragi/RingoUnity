using RingoLib.Core.Models;

namespace RingoLib.Search.SearchAction.Services.Helpers
{
	public readonly struct GetStageListResponse
	{
		public GetStageListResponse(
			Stage[] stages
	    )
		{
			Stages = stages;
		}

		public Stage[] Stages { get; }
	}
}
