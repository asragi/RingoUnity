using RingoLib.Core.ValueObjects;

namespace RingoUnity.Search.SearchDetail
{
    internal readonly struct SearchDetailArgs
    {
        internal SearchDetailArgs(
            string displayName,
            string description,
            RequiedItem[] requiedItems,
            EarningItem[] earningItems,
            RequiedSkill[] requiedSkills,
            int requiredPayment,
            int reqStamina
            ) {
            DisplayName = displayName;
            Description = description;
            RequiedItems = requiedItems;
            EarningItems = earningItems;
            RequiredPayment = requiredPayment;
            RequiedSkills = requiedSkills;
            RequiredStamina = reqStamina;
        }

        internal string DisplayName { get; }
        internal string Description { get; }
        internal RequiedItem[] RequiedItems { get; }
        internal EarningItem[] EarningItems { get; }
        internal RequiedSkill[] RequiedSkills { get; }
        internal int RequiredPayment { get; }
        internal int RequiredStamina { get; }

    }
}