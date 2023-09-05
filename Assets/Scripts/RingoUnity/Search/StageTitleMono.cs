using TMPro;
using UnityEngine;

public class StageTitleMono : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _stageTitleText;
    [SerializeField]
    private TextMeshProUGUI _stageDescText;

    internal void Initialize(
        string displayText, string descText)
    {
        _stageTitleText.text = displayText;
        _stageDescText.text = descText;
    }
}
