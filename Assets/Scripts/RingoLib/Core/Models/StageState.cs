using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
	public readonly struct StageState
	{
		public StageState(
			UserId userId,
			StageId stageId,
			bool isAccessable,
			bool isVisible,
			bool isKnown,
			ExploreAction[] actions
			) {
			UserId = userId;
			StageId = stageId;
			IsAccessable = isAccessable;
			IsVisible = isVisible;
			IsKnown = isKnown;
			Actions = actions;
		}

		public UserId UserId { get; }
		public StageId StageId { get; }
		public bool IsAccessable { get; }
		public bool IsVisible { get; }
		public bool IsKnown { get; }
		public ExploreAction[] Actions { get; }
	}
}
