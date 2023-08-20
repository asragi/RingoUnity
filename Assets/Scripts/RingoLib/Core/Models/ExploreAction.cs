using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
    public readonly struct ExploreAction
    {
        public string ActionId { get; }
        public string DisplayName { get; }
        public ItemId[] RewardItems { get; }
        public (ItemId, int)[] RequiredItems { get; }
        public (SkillId, int)[] RequiredSkills { get; }
        public bool IsVisible { get; }
        public bool IsKnown { get; }
        public bool IsPossible { get; }
    }
}
