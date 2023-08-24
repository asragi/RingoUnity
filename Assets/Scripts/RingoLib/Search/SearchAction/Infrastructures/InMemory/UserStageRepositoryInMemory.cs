using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RingoLib.Core.Models;
using RingoLib.Core.ValueObjects;
using RingoLib.Search.SearchAction.Repositories;
using RingoLib.Search.SearchAction.Repositories.DTO;

namespace RingoLib.Search.SearchAction.Infrastructures.InMemory
{
	public class UserStageRepositoryInMemory: IUserStageRepository
	{
        private static readonly StageMasterInMemory _stageMaster;
		private readonly Dictionary<StageId, StageState> _dict;

        static UserStageRepositoryInMemory() {
            _stageMaster = new();
	    }

		public UserStageRepositoryInMemory()
		{
			_dict = new() { };
		}

        public Task<GetDetailRepoResponse> GetStageDetail(UserId _, StageId stageId)
        {
            return new(() => new(_dict[stageId]));
        }

        public Task<GetStageListRepoResponse> GetStageList(UserId _)
        {
            return new(() => new(_dict.Values.ToArray()));
        }
    }
}
