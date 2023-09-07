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
            var allStageId = StageMasterInMemory.AllStageId;
            var userId = UserClientInMemory.MockUserId;
            _dict = new()
            {
                {userId, new(){
                    { allStageId[0], new(userId, allStageId[0], true, true, true, StageMasterInMemory.Explores[allStageId[0]].Select(
                        id => new ExploreAction(userId, id, true, true, true)).ToArray()) },
                } }
            };
        }

        public StageState[] GetAllStages(UserId userId) => _dict[userId].Values.ToArray();
    }
}