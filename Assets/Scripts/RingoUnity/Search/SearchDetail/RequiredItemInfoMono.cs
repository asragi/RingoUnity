using RingoUnity.Search.SearchDetail;
using UnityEngine;

public class RequiredItemInfoMono : MonoBehaviour
{
    [SerializeField]
    private Transform _parent;
    [SerializeField]
    private ItemIconMono _itemIconPrefab;

    internal void Initialize(RequiedItem[] requiredItems)
    {
        for (int i = 0; i < requiredItems.Length; i++)
        {
            var item = requiredItems[i];
            var obj = Instantiate(_itemIconPrefab, _parent);
            obj.Initialize(item.ItemId);
        }
    }
}
