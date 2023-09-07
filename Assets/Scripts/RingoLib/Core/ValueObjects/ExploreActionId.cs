namespace RingoLib.Core.ValueObjects
{
    public record ExploreActionId
    {
        public ExploreActionId(string id)
        {
            Id = id;
        }

        public string Id { get; }
    };
}
