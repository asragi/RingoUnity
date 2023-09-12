using RingoUnity.Search.SearchDetail;
using UnityEngine;

public class SearchDetailMono : MonoBehaviour
{
    [SerializeField]
    private StageTitleMono _stageTitle;
    [SerializeField]
    private RequiredCostMono _requiredCost;
    [SerializeField]
    private EarningItemInfoMono _earningItemInfo;
    [SerializeField]
    private RequiredItemInfoMono _requiredItemInfo;
    [SerializeField]
    private RequiredSkillListMono _requiredSkillList;
    [SerializeField]
    private CounterMono _counter;
    [SerializeField]
    private OKButtonMono _oKButton;

    internal void Initialize(SearchDetailArgs args)
    {
        _stageTitle.Initialize(args.DisplayName, args.Description);
        _requiredCost.Initialize(args.RequiredPayment, args.RequiredStamina);
        _earningItemInfo.Initialize(args.EarningItems);
        _requiredItemInfo.Initialize(args.RequiedItems);
        _requiredSkillList.Initialize(args.RequiedSkills);
        _counter.Initialize(0);
        _oKButton.Initialize(OnSubmit);
    }

    private void OnSubmit()
    {
        Debug.Log($"Submit: {_counter.Index}");
    }
}
