using RingoLib.Search.SearchAction.Services;
using System.Collections;
using System.Collections.Generic;

public class StageList
{
    private readonly GetStageService _service;

    internal StageList(
        GetStageService service)
    {
        _service = service;
    }
}
