using RingoLib.Core.Models;
using RingoLib.Core.ValueObjects;

namespace RingoLib.Search.SearchAction.Repositories.DTO
{
    public readonly struct GetDetailRepoResponse
    {
        public GetDetailRepoResponse(
            StageId stageId,
            UserId userId,
            string displayName,
            bool isAccessable,
            bool isVisible,
            bool isKnown,
            ExploreAction[] actions
            ) {
            StageId = stageId;
            UserId = userId;
            DisplayName = displayName;
            IsAccessable = isAccessable;
            IsVisible = isVisible;
            Actions = actions;
            IsKnown = isKnown;
	    }

        public string DisplayName { get; }
		public UserId UserId { get; }
		public StageId StageId { get; }
		public bool IsAccessable { get; }
		public bool IsVisible { get; }
		public bool IsKnown { get; }
		public ExploreAction[] Actions { get; }

    }
}
