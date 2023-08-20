using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
	public readonly struct Stage
	{
		public StageId StageId { get; }
		public bool IsAccessable { get; }
		public bool IsVisible { get; }
		public bool IsKnown { get; }
		public string DisplayName { get; }
		public ExploreAction[] Actions { get; }
	}
}
