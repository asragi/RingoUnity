using RingoLib.Core.ValueObjects;
using RingoLib.Search.SearchAction.Services;
using RingoLib.Search.SearchAction.Services.Helpers;
using System;
using System.Linq;

public class StageList
{
    private readonly UserId _userId;
    private readonly GetStageService _service;
    private readonly Action<StagePanelModel[]> _onLoadComplete;
    private readonly Action _onLoadStart;
    private readonly Action _onLoadFailed;


    internal StageList(
        UserId userId,
        GetStageService service,
        Action<StagePanelModel[]> onLoadComplete,
        Action onLoadStart,
        Action onLoadFailed)
    {
        _userId = userId;
        _service = service;
        _onLoadStart = onLoadStart;
        _onLoadFailed = onLoadFailed;
        _onLoadComplete = onLoadComplete;
    }

    internal void GetStages()
    {
        _service.GetStageList(new(
            _userId.Id
            )).ContinueWith(res => OnLoadComplete(res.Result))
            .ContinueWith(result => UnityEngine.Debug.Log(result.Exception));
        OnLoadStart();
    }

    private void OnLoadComplete(GetStageListResponse result)
    {
        var stages = result.Stages;
        var arr = stages.Select(
            stage => new StagePanelModel(
                stage.DisplayName,
                stage.Description,
                stage.Actions.Select(
                    action => new StageActionModel(
                        action.DisplayName,
                        action.IsPossible,
                        true,
                        true, OnValidSelect(action.ExploreActionId), OnInvalidSelect))
                .ToArray())).ToArray();
        _onLoadComplete(arr);
    }

    private void OnLoadStart() {
        _onLoadStart();
    }

    private Action OnValidSelect(ExploreActionId id)
    {
        return () => { };
    }

    private void OnInvalidSelect()
    {

    }
}
