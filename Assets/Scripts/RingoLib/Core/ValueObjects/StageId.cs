namespace RingoLib.Core.ValueObjects
{
    public readonly struct StageId
    {
        public StageId(string id) => Id = id;
        public string Id { get; }
    }
}
