using TMPro;
using UnityEngine;

public class RequiredCostMono : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _paymentText, _staminaText;

    internal void Initialize(int requiredPay, int requiredStamina)
    {
        _paymentText.text = requiredPay.ToString();
        _staminaText.text = requiredStamina.ToString();
    }
}
