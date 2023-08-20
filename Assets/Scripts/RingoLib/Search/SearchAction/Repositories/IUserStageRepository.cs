using System.Threading.Tasks;
using RingoLib.Core.ValueObjects;
using RingoLib.Search.SearchAction.Repositories.DTO;

namespace RingoLib.Search.SearchAction.Repositories
{
    public interface IUserStageRepository
    {
        Task<GetStageListRepoResponse> GetStageList(UserId userId);
        Task<GetDetailRepoResponse> GetStageDetail(UserId userId, StageId stageId);
    }
}
