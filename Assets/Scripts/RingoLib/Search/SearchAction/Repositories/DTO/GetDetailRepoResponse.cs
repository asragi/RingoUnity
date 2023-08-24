using RingoLib.Core.Models;

namespace RingoLib.Search.SearchAction.Repositories.DTO
{
    public readonly struct GetDetailRepoResponse
    {
        public GetDetailRepoResponse(StageState stage) {
            Stage = stage; 
	    }

        public StageState Stage { get; }
    }
}
