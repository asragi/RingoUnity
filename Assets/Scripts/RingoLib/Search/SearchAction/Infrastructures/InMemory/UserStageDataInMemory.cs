using RingoLib.Core.Infrastructures.InMemory;
using RingoLib.Core.Models;
using RingoLib.Core.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace RingoLib.Search.SearchAction.Infrastructures.InMemory
{
    public class UserStageDataInMemory
    {
        private static readonly Dictionary<UserId, Dictionary<StageId, StageState>> _dict;

        static UserStageDataInMemory()
        {
            _dict = new()
            {
                {UserClientInMemory.MockUserId, new(){ } }
            };
        }

        public StageState[] GetAllStages(UserId userId) => _dict[userId].Values.ToArray();
    }
}