using System;

public readonly struct StageActionModel
{
    internal StageActionModel(
        string displayText,
        bool isPossible,
        bool shouldDisplay,
        bool isNew,
        Action onValid,
        Action onInvalid
        )
    {
        DisplayText = displayText;
        IsPossible = isPossible;
        ShouldDisplayText = shouldDisplay;
        IsNew = isNew;
        OnValidSelect = onValid;
        OnInvalidSelect = onInvalid;
    }

    internal string DisplayText { get; }
    internal bool IsPossible { get; }
    internal bool ShouldDisplayText { get; }
    internal bool IsNew { get; }
    internal Action OnValidSelect { get; }
    internal Action OnInvalidSelect { get; }
}
