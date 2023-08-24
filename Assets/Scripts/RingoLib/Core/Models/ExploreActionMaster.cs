using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
    public readonly struct ExploreActionMaster
    {
        public ExploreActionId ExploreActionId { get; }
        public string DisplayName { get; }
        public ItemId[] RewardItems { get; }
        public (ItemId, int)[] RequiredItems { get; }
        public (SkillId, int)[] RequiredSkills { get; }
    }
}
