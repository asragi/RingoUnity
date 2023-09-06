using RingoLib.Core.Repositories;
using RingoLib.Core.ValueObjects;

namespace RingoLib.Core.Infrastructures.InMemory
{
    public class UserClientInMemory : IUserClient
    {
        public static UserId MockUserId { get; } = new("InMemoryDevUser");
        public UserId UserId => MockUserId;
    }
}