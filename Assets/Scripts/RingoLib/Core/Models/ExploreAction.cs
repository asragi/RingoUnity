using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
    public readonly struct ExploreAction
    {
        public string ActionId { get; }
        public UserId UserId { get; }
        public ExploreActionId ExploreActionId { get; }
        public bool IsVisible { get; }
        public bool IsKnown { get; }
        public bool IsPossible { get; }
    }
}
