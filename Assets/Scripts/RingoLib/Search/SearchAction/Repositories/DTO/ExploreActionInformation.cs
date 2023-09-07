using RingoLib.Core.ValueObjects;

namespace RingoLib.Search.SearchAction.Repositories.DTO
{
	public readonly struct ExploreActionInformation
	{
        public ExploreActionInformation(
            UserId userId,
            ExploreActionId id,
            bool isVisible,
            bool isPossible,
            bool isKnown,
            string displayName)
        {
            UserId = userId;
            ExploreActionId = id;
            DisplayName = displayName;
            IsVisible = isVisible;
            IsPossible = isPossible;
            IsKnown = isKnown;
        }

        public UserId UserId { get; }
        public ExploreActionId ExploreActionId { get; }
        public string DisplayName { get; }
        public bool IsVisible { get; }
        public bool IsKnown { get; }
        public bool IsPossible { get; }
	}
}
