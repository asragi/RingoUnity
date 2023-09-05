using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StageActionPanelMono : MonoBehaviour
{
    private readonly static string PlaceHolder = "？？？？？";
    private StageActionPanel _panel;
    private Button _button;
    [SerializeField]
    private TextMeshProUGUI _text;

    public void Initialize(StageActionModel actionModel)
    {
        _button = GetComponent<Button>();
        SetButtonClickable(actionModel.IsPossible);
        _text.text = actionModel.ShouldDisplayText ? actionModel.DisplayText : PlaceHolder;
        _panel = new(
            actionModel.IsPossible,
            actionModel.OnValidSelect,
            actionModel.OnInvalidSelect);
    }

    public void OnSelected()
    {
        _panel.OnSelect();
    }

    private void SetButtonClickable(bool isPossible)
    {
        _button.interactable = isPossible;
    }
}
