using RingoUnity.Search.SearchDetail;
using UnityEngine;

public class EarningItemInfoMono : MonoBehaviour
{
    [SerializeField]
    private Transform _parent;
    [SerializeField]
    private ItemIconMono _itemIconPrefab;

    internal void Initialize(EarningItem[] earningItems)
    {
        for (int i = 0; i < earningItems.Length; i++)
        {
            var item = earningItems[i];
            var obj = Instantiate(_itemIconPrefab, _parent);
            obj.Initialize(item.ItemId);
        }
    }
}
