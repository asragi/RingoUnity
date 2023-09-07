using System;
using System.Linq;
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
            return Task.Run(async () =>
            {
                var stages = _stageMaster.GetAllStages();
                var states = _userStageDataInMemory.GetAllStages(userId);
                var stateDict = states.ToDictionary(state => state.StageId, state => state);
                var result = new StageInformation[stages.Length];
                for (int i = 0; i < result.Length; i++)
                {
                    var stage = stages[i];
                    var stageId = stage.StageId;
                    var stageActionDict = stage.Actions.ToDictionary(s => s.ExploreActionId, s => s);
                    if (!stateDict.ContainsKey(stageId)) {
                        result[i] = new(
                            userId,
                            stageId,
                            stage.DisplayName,
                            stage.Description,
                            true,
                            true,
                            false,
                            Array.Empty<ExploreActionInformation>());
                        continue;
                    }
                    var actions = new ExploreActionInformation[stage.Actions.Length];
                    for (int j = 0; j < actions.Length; j++)
                    {
                        var actState = stateDict[stageId].Actions[j];
                        var actId = actState.ExploreActionId;
                        actions[j] = new(
                            userId,
                            actId,
                            actState.IsVisible,
                            actState.IsPossible,
                            actState.IsKnown,
                            stageActionDict[actId].DisplayName
                            );
                    }
                    var state = stateDict[stageId];
                        result[i] = new(
                            userId,
                            stageId,
                            stage.DisplayName,
                            stage.Description,
                            state.IsAccessable,
                            state.IsVisible,
                            state.IsKnown,
                            actions);
                }

                await Task.Delay(1000);
                return new GetStageListRepoResponse(result);
            });
        }
    }
}
