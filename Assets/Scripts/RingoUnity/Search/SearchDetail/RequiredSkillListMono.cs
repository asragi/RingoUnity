using RingoUnity.Search.SearchDetail;
using UnityEngine;

public class RequiredSkillListMono : MonoBehaviour
{
    [SerializeField]
    private RequiredSkillRowMono _requiredSkillRowPrefab;
    [SerializeField]
    private Transform _parent;

    internal void Initialize(RequiedSkill[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            var arg = args[i];
            var obj = Instantiate(_requiredSkillRowPrefab, _parent);
            obj.Initialize(arg);
        }
    }
}
