using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RingoLib.Core.ValueObjects;
using RingoLib.Search.SearchAction.Repositories;
using RingoLib.Search.SearchAction.Repositories.DTO;

namespace RingoLib.Search.SearchAction.Infrastructures.InMemory
{
	public class UserStageRepositoryInMemory: IUserStageRepository
	{
        private static readonly StageMasterInMemory _stageMaster;
        private static readonly UserStageDataInMemory _userStageDataInMemory;

        static UserStageRepositoryInMemory() {
            _stageMaster = new();
            _userStageDataInMemory = new();
	    }

        public Task<GetDetailRepoResponse> GetStageDetail(UserId userId, StageId stageId)
        {
            var stageMaster = _stageMaster.Get(stageId);
            // var state = _userStageDataInMemory.Get(userId);

            throw new System.NotImplementedException();
            // return new(() => new(_dict[stageId]));
        }

        public Task<GetStageListRepoResponse> GetStageList(UserId userId)
        {
            return Task.Run(() =>
            {
                var stages = _stageMaster.GetAllStages();
                var states = _userStageDataInMemory.GetAllStages(userId);
                // Thread.Sleep(1000);
                return new GetStageListRepoResponse(states);
            });
        }
    }
}
