using RingoLib.Core.ValueObjects;

namespace RingoLib.Search.SearchAction.Services.Helpers
{
    public readonly struct GetDetailRequest
    {
        public UserId UserId { get; }
        public StageId StageId { get; }
    }
}
