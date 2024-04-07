using RingoLib.Core.Models;

namespace RingoLib.Search.SearchAction.Services.Helpers
{
    public readonly struct GetDetailResponse
    {
        internal GetDetailResponse(StageState stage) {
            Stage = stage;
	    }


        public StageState Stage { get; }
    }
}
