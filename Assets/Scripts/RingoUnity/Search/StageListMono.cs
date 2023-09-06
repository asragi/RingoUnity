using RingoLib.Search.SearchAction.Services;
using RingoUnity.DI;
using UnityEngine;

public class StageListMono : MonoBehaviour
{
    [SerializeField]
    private DIComponent _diComponent;
    [SerializeField]
    private StagePanelMono _stagePanelPrefab;
    [SerializeField]
    private Transform _stageParent;

    private void Awake()
    {
        /*
        var stages = new StagePanelModel[]
        {
            new(
                "ポムの森",
                "近場にある小さな森\nりんごの木がこれでもかというほどある",
                new StageActionModel[] {
                    new("りんごを採りに行く", true, true, false, () => { }, () => { }),
                    new("石や木を拾いに行く", true, true, true, () => { }, () => { })
                }
            ),
            new(
                "リゴー火山",
                "丸みのある大きな火山\n赤い石がよく取れる地質",
                new StageActionModel[] {
                    new("鉱石を採りに行く", true, true, false, () => { }, () => { }),
                    new("火山に修行しに行く", false, true, true, () => { }, () => { }),
                    new("聖剣を探しに行く", false, false, false, () => { }, () => { }),
                }
            ),
        };
        Initialize(stages);
        */
        Initialize();
    }

    internal void Initialize()
    {
        var userStageRepo = _diComponent.UserStageRepository;
        var userClient = _diComponent.UserClient;
        var service = new GetStageService(userStageRepo);
        var userId = userClient.UserId;
        var stageList = new StageList(userId, service, OnLoadComplete, OnLoadStart, OnLoadFailed);
        stageList.GetStages();
    }

    private void OnLoadComplete(StagePanelModel[] stageModels)
    {
        Debug.Log("Complete");
        CreateStages(stageModels);
        
        void CreateStages(StagePanelModel[] stages)
        {
            if (stages.Length == 0) return;
            for (int i = 0; i < stages.Length; i++)
            {
                var stage = stages[i];
                var stageObject = Instantiate(_stagePanelPrefab, _stageParent);
                stageObject.Initialize(stage);
                var rectTransform = stageObject.GetComponent<RectTransform>();
            }
        }
    }

    private void OnLoadStart()
    {
        Debug.Log("Start");
    }

    private void OnLoadFailed()
    {
    }
}
