using RingoUnity.Search.SearchDetail;
using UnityEngine;

public class RequiredItemIconMono : MonoBehaviour
{
    internal void Initialize(RequiedItem item)
    {
        var itemIcon = GetComponent<ItemIconMono>();
        itemIcon.Initialize(item.ItemId);
    }
}
