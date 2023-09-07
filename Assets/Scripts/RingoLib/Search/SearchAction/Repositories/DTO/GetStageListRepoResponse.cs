namespace RingoLib.Search.SearchAction.Repositories.DTO
{
    public readonly struct GetStageListRepoResponse
    {
        public GetStageListRepoResponse(StageInformation[] stages)
            => Stages = stages;
        public StageInformation[] Stages { get; }
    }
}
