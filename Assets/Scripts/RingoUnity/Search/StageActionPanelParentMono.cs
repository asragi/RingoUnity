using UnityEngine;

public class StageActionPanelParentMono : MonoBehaviour
{
    private static readonly float s_margin = 8;
    private static float _panelHeight = 0;
    [SerializeField]
    private StageActionPanelMono _stageActionPanelPrefab;
    private float _overallHeight = 0;

    private void Awake()
    {
        var actions = new StageActionModel[] {
            new("‚è‚ñ‚²‚ðÌ‚è‚És‚­", true, true, false, () => { }, () => { }),
            new("Î‚â–Ø‚ðE‚¢‚És‚­", true, true, true, () => { }, () => { })
        };
        Initialize(actions);
    }

    internal void Initialize(StageActionModel[] actions)
    {
        if (actions.Length == 0) return;
        SetHeight();
        CreatePanels();
        SetOverAllHeight();

        void SetHeight()
        {
            if (_panelHeight != 0) return;
            var rect = _stageActionPanelPrefab.GetComponent<RectTransform>();
            _panelHeight = rect.sizeDelta.y;
        }

        void CreatePanels()
        {
            var parent = transform;
            for (int i = 0; i < actions.Length; i++)
            {
                StageActionModel action = actions[i];
                var panel = Instantiate(_stageActionPanelPrefab, parent);
                var child = panel.GetComponent<RectTransform>();
                child.anchoredPosition = new(
                    child.anchoredPosition.x,
                    - (_panelHeight + s_margin) * i
                    );
                panel.Initialize(action);
            }
        }

        void SetOverAllHeight()
        {
            var panelLength = actions.Length;
            if (panelLength == 0)
            {
                _overallHeight = 0;
                return;
            }
            _overallHeight = _panelHeight * panelLength + s_margin * (panelLength - 1);
        }
    }

    internal float GetOverAllHeight => _overallHeight;
}
