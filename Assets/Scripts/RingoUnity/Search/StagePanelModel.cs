internal readonly struct StagePanelModel
{
    internal StagePanelModel(
        string displayName, 
        string description,
        StageActionModel[] actions)
    {
        DisplayName = displayName;
        Description = description;
        Actions = actions;
    }
    
    internal string DisplayName { get; }
    internal string Description { get; }
    internal StageActionModel[] Actions { get; }
}
