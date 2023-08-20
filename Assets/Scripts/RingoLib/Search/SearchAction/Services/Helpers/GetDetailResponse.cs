using RingoLib.Core.Models;

namespace RingoLib.Search.SearchAction.Services.Helpers
{
    public readonly struct GetDetailResponse
    {
        internal GetDetailResponse(Stage stage) {
            Stage = stage;
	    }

        public Stage Stage { get; }
    }
}
