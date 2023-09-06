using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Repositories
{
    public interface IUserClient
    {
        public UserId UserId { get; }
    }
}