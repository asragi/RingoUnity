namespace RingoLib.Core.ValueObjects
{
    public readonly struct UserId
    {
        public UserId(string id) => Id = id;
        public string Id { get; }
    }
}
