using RingoLib.Core.ValueObjects;
using RingoLib.Search.SearchAction.Services;
using RingoUnity.DI;
using System;
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

    internal void Initialize(Action<ExploreActionId> onSelect)
    {
        var userStageRepo = _diComponent.UserStageRepository;
        var userClient = _diComponent.UserClient;
        var service = new GetStageService(userStageRepo);
        var userId = userClient.UserId;
        var stageList = new StageList(userId,
            service,
            OnLoadComplete,
            OnLoadStart,
            OnLoadFailed,
            onSelect);
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
