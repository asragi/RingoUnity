using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
    public readonly struct ExploreActionMaster
    {
        public ExploreActionMaster(
            ExploreActionId exploreActionId,
            string displayName,
            string description,
            ItemId[] rewardItems,
            (ItemId, int)[] requiredI,
            (SkillId, int)[] requiredSkills
            )
        {
            ExploreActionId = exploreActionId;
            DisplayName = displayName;
            Description = description;
            RewardItems = rewardItems;
            RequiredItems = requiredI;
            RequiredSkills = requiredSkills;
        }

        public ExploreActionId ExploreActionId { get; }
        public string DisplayName { get; }
        public string Description { get; }
        public ItemId[] RewardItems { get; }
        public (ItemId, int)[] RequiredItems { get; }
        public (SkillId, int)[] RequiredSkills { get; }
    }
}
