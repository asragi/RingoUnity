using RingoLib.Core.Models;

namespace RingoLib.Search.SearchAction.Repositories.DTO
{
    public readonly struct GetStageListRepoResponse
    {
        public GetStageListRepoResponse(StageState[] stages)
            => Stages = stages;
        public StageState[] Stages { get; }
    }
}
