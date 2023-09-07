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
                "�|���̐X",
                "�ߏ�ɂ��鏬���ȐX\n��񂲂̖؂�����ł����Ƃ����قǂ���",
                new StageActionModel[] {
                    new("��񂲂��̂�ɍs��", true, true, false, () => { }, () => { }),
                    new("�΂�؂��E���ɍs��", true, true, true, () => { }, () => { })
                }
            ),
            new(
                "���S�[�ΎR",
                "�ۂ݂̂���傫�ȉΎR\n�Ԃ��΂��悭����n��",
                new StageActionModel[] {
                    new("�z�΂��̂�ɍs��", true, true, false, () => { }, () => { }),
                    new("�ΎR�ɏC�s���ɍs��", false, true, true, () => { }, () => { }),
                    new("������T���ɍs��", false, false, false, () => { }, () => { }),
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
