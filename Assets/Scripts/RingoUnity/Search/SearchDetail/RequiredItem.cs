using RingoLib.Core.ValueObjects;

namespace RingoUnity.Search.SearchDetail
{
    internal readonly struct RequiedItem
    {
        internal ItemId ItemId { get; }
        internal int RequiedCount { get; }
        internal int Stock { get; }
        internal bool IsKnown { get; }
    }
}