using RingoLib.Core.Models;
using RingoLib.Core.ValueObjects;

namespace RingoLib.Search.SearchAction.Repositories.DTO
{
	public readonly struct StageInformation
	{
		public StageInformation(
		UserId userId,
		StageId stageId,
		string displayName,
		string description,
		bool isAccessable,
		bool isVisible,
		bool isKnown,
		ExploreActionInformation[] actions
		)
		{
			UserId = userId;
			StageId = stageId;
			DisplayName = displayName;
			Description = description;
			IsAccessable = isAccessable;
			IsVisible = isVisible;
			IsKnown = isKnown;
			Actions = actions;
		}

		public UserId UserId { get; }
		public StageId StageId { get; }
		public string DisplayName { get; }
		public string Description { get; }
		public bool IsAccessable { get; }
		public bool IsVisible { get; }
		public bool IsKnown { get; }
		public ExploreActionInformation[] Actions { get; }
	}
}
