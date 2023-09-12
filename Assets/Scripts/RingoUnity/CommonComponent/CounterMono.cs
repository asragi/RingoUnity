using TMPro;
using UnityEngine;

public class CounterMono : MonoBehaviour
{
    private readonly static int MaxCount = 99;
    [SerializeField]
    private TextMeshProUGUI _countText;

    private int _count;
    
    internal void Initialize(int initialCount)
    {
        _count = initialCount;
    }

    public void OnInputUp() => OnChange(1);
    public void OnInputLargeUp() => OnChange(10);
    public void OnInputDown() => OnChange(-1);
    public void OnInputLargeDown() => OnChange(-10);
    internal int Index => _count;
    
    private void OnChange(int diff)
    {
        _count = Mathf.Clamp(_count + diff, 0, MaxCount);
        _countText.text = _count.ToString();
    }
}
