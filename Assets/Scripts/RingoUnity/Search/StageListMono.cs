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
                "ƒ|ƒ€‚ÌX",
                "‹ßê‚É‚ ‚é¬‚³‚ÈX\n‚è‚ñ‚²‚Ì–Ø‚ª‚±‚ê‚Å‚à‚©‚Æ‚¢‚¤‚Ù‚Ç‚ ‚é",
                new StageActionModel[] {
                    new("‚è‚ñ‚²‚ðÌ‚è‚És‚­", true, true, false, () => { }, () => { }),
                    new("Î‚â–Ø‚ðE‚¢‚És‚­", true, true, true, () => { }, () => { })
                }
            ),
            new(
                "ƒŠƒS[‰ÎŽR",
                "ŠÛ‚Ý‚Ì‚ ‚é‘å‚«‚È‰ÎŽR\nÔ‚¢Î‚ª‚æ‚­Žæ‚ê‚é’nŽ¿",
                new StageActionModel[] {
                    new("zÎ‚ðÌ‚è‚És‚­", true, true, false, () => { }, () => { }),
                    new("‰ÎŽR‚ÉCs‚µ‚És‚­", false, true, true, () => { }, () => { }),
                    new("¹Œ•‚ð’T‚µ‚És‚­", false, false, false, () => { }, () => { }),
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
