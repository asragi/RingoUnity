﻿using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Models
{
    public readonly struct ExploreAction
    {
        public ExploreAction(
            UserId userId,
            ExploreActionId id,
            bool isVisible,
            bool isPossible,
            bool isKnown)
        {
            UserId = userId;
            ExploreActionId = id;
            IsVisible = isVisible;
            IsPossible = isPossible;
            IsKnown = isKnown;
        }

        public UserId UserId { get; }
        public ExploreActionId ExploreActionId { get; }
        public bool IsVisible { get; }
        public bool IsKnown { get; }
        public bool IsPossible { get; }
    }
}
