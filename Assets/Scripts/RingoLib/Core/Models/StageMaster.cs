using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
	public readonly struct StageMaster
	{
		public StageId StageId { get; }
		public string DisplayName { get; }
		public ExploreAction[] Actions { get; }
	}
}
