using RingoLib.Core.ValueObjects;

namespace RingoUnity.Search.SearchDetail
{
    internal readonly struct RequiedSkill
    {
        internal SkillId SkillId { get; }
        internal string DisplayName { get; }
        internal int SkillLv { get; }
        internal int RequiredLv { get; }
    }
}