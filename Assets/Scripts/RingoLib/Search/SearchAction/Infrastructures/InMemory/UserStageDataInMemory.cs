using RingoLib.Core.Models;
using RingoLib.Core.ValueObjects;
using System.Collections.Generic;

namespace RingoLib.Search.SearchAction.Infrastructures.InMemory
{
    public class UserStageDataInMemory
    {
        private static readonly Dictionary<UserId, StageState> _dict;

        static UserStageDataInMemory()
        {
            _dict = new();
        }

        public StageState Get(UserId userId) => _dict[userId];
    }
}