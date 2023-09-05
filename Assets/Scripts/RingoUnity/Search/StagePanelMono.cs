using UnityEngine;

public class StagePanel : MonoBehaviour
{
    [SerializeField]
    private StageTitleMono _stageTitleMono;
    [SerializeField]
    private StageActionPanelParentMono _stageActionPanelParentMono;

    internal void Initialize(StagePanelModel stageModel)
    {
        _stageTitleMono.Initialize(stageModel.DisplayName, stageModel.Description);
        _stageActionPanelParentMono.Initialize(stageModel.Actions);
    }
}
