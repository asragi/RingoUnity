using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
	public readonly struct StageMaster
	{
		public StageMaster(
            StageId stageId,
            string name,
			string desc,
            ExploreActionMaster[] actions)
		{
			StageId = stageId;
			DisplayName = name;
			Description = desc;
			Actions = actions;
		}

		public StageId StageId { get; }
		public string DisplayName { get; }
		public string Description { get; }
		public ExploreActionMaster[] Actions { get; }
	}
}
