using RingoLib.Core.ValueObjects;
using RingoUnity.Search.SearchDetail;
using TMPro;
using UnityEngine;

public class SkillRowMono : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _skillNameText;
    [SerializeField]
    TextMeshProUGUI _skillLvValueText;

    internal void Initialize(RequiedSkill args)
    {
        _skillNameText.text = args.DisplayName;
        _skillLvValueText.text = args.SkillLv.ToString();
    }

    internal readonly struct SkillRowArgs
    {
        internal SkillId SkillId { get; }
        internal string DisplayName { get; }
        internal int SkillLv { get; }
        internal float SkillExpRate { get; }
    }
}
