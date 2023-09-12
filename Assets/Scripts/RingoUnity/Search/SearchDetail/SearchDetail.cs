using RingoLib.Search.SearchAction.Repositories;
using RingoLib.Search.SearchAction.Services;
using RingoLib.Search.SearchAction.Services.Helpers;
using System;

namespace RingoUnity.Search.SearchDetail
{
    internal class SearchDetail
    {
        private readonly GetStageService _service;
        private readonly Action<SearchDetailArgs> _onLoadComplete;
        private readonly Action _onLoadStart;

        internal SearchDetail(
            IUserStageRepository stageRepo,
            Action onLoadingStart,
            Action<SearchDetailArgs> onLoadingComplete)
        {
            _service = new(stageRepo);
        }

        internal void CreateArgs()
        {
            var res = _service.GetDetail(new())
                .ContinueWith(result => ToArgs(result.Result));
            _onLoadStart();
        }

        private static SearchDetailArgs ToArgs(GetDetailResponse res)
        {
            var stage = res.Stage;
            return new(
                );
        }
    }
}
