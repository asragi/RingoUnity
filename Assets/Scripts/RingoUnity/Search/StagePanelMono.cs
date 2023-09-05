using UnityEngine;

public class StagePanelMono : MonoBehaviour
{
    private static readonly float s_padding = 8;
    [SerializeField]
    private StageTitleMono _stageTitleMono;
    [SerializeField]
    private StageActionPanelParentMono _stageActionPanelParentMono;

    private void Awake()
    {
        var actions = new StageActionModel[] {
            new("りんごを採りに行く", true, true, false, () => { }, () => { }),
            new("石や木を拾いに行く", true, true, true, () => { }, () => { })
        };
        Initialize(new("リゴー火山", "丸みのある火山\n赤い鉱石がよく見つかる", actions ));
    }

    internal void Initialize(StagePanelModel stageModel)
    {
        _stageTitleMono.Initialize(stageModel.DisplayName, stageModel.Description);
        _stageActionPanelParentMono.Initialize(stageModel.Actions);
        SetWindowSize();

        void SetWindowSize()
        {
            var rect = GetComponent<RectTransform>();
            var height = CalclateHeight();
            rect.sizeDelta = new(
                rect.sizeDelta.x,
                height
                );

            float CalclateHeight() => GetTitleHeight() + GetActionsPanelHeight() + s_padding * 2;
            float GetTitleHeight() { return 98 + 8; }
            float GetActionsPanelHeight() => _stageActionPanelParentMono.GetOverAllHeight;
        }
    }
}
