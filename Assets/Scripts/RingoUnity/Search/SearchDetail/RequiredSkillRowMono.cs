using TMPro;
using UnityEngine;

namespace RingoUnity.Search.SearchDetail
{
    internal class RequiredSkillRowMono: MonoBehaviour
    {
        [SerializeField]
        private SkillRowMono _skillRowMono;
        [SerializeField]
        private TextMeshProUGUI _requiredSkillLvText;

        internal void Initialize(RequiedSkill rowArgs)
        {
            _skillRowMono.Initialize(rowArgs);
            _requiredSkillLvText.text = $"Lv.{rowArgs.RequiredLv}";
        }
    }
}