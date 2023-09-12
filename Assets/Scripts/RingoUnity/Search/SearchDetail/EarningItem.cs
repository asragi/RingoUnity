using RingoLib.Core.ValueObjects;

namespace RingoUnity.Search.SearchDetail
{
    internal readonly struct EarningItem
    {
        internal ItemId ItemId { get; }
        internal bool IsKnown { get; }
    }
}
