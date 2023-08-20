using System;
namespace RingoLib.Search.SearchAction.Services.Helpers
{
	public readonly struct GetStageListRequest
	{
		public GetStageListRequest(string userId)
		{
			UserId = userId;
		}

		public string UserId { get; }
	}
}

