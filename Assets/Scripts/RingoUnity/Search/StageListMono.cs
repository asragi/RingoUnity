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

    private StagePanelModel[] _stagesToDraw;
    private bool _isLoading;
    private bool _isDisplayed;

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

    private void Update()
    {
        DisplayStagePanels();
    }

    private void DisplayStagePanels()
    {
        if (_isDisplayed) return;
        if (_isLoading) return;
        CreateStages(_stagesToDraw);
        _isDisplayed = true;

        void CreateStages(StagePanelModel[] stages)
        {
            if (stages.Length == 0) return;
            for (int i = 0; i < stages.Length; i++)
            {
                var stage = stages[i];
                var stageObject = Instantiate(_stagePanelPrefab, _stageParent);
                stageObject.Initialize(stage);
            }
        }
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
        _stagesToDraw = stageModels;
        _isLoading = false;
    }

    private void OnLoadStart()
    {
        _isLoading = true;
    }

    private void OnLoadFailed()
    {
    }
}
