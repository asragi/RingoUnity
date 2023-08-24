using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
	public readonly struct StageState
	{
		public UserId UserId { get; }
		public StageId StageId { get; }
		public bool IsAccessable { get; }
		public bool IsVisible { get; }
		public bool IsKnown { get; }
		public ExploreAction[] Actions { get; }
	}
}
