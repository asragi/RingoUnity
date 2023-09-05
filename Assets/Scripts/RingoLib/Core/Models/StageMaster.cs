using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
	public readonly struct StageMaster
	{
		public StageMaster(StageId stageId, string name, ExploreActionMaster[] actions)
		{
			StageId = stageId;
			DisplayName = name;
			Actions = actions;
		}

		public StageId StageId { get; }
		public string DisplayName { get; }
		public ExploreActionMaster[] Actions { get; }
	}
}
