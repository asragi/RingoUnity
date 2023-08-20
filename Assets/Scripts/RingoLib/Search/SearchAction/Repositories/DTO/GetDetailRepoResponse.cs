using RingoLib.Core.Models;

namespace RingoLib.Search.SearchAction.Repositories.DTO
{
    public readonly struct GetDetailRepoResponse
    {
        public GetDetailRepoResponse(Stage stage) {
            Stage = stage; 
	    }

        public Stage Stage { get; }
    }
}
