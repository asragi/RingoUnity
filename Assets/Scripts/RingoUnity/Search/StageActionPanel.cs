using System;

public class StageActionPanel
{
    private readonly bool _isPossible;
    private readonly Action _onValidSelect;
    private readonly Action _onInvalidSelect;

    internal StageActionPanel(
        bool isPossible,
        Action onValidSelect,
        Action onInvalidSelect)
    {
        _isPossible = isPossible;
        _onValidSelect = onValidSelect;
        _onInvalidSelect = onInvalidSelect;
    }

    internal void OnSelect()
    {
        if (!_isPossible)
        {
            _onInvalidSelect();
            return;
        }
        _onValidSelect();
    }
}
