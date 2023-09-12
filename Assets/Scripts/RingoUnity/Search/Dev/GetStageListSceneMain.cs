using RingoLib.Core.ValueObjects;
using RingoUnity.DI;
using UnityEngine;

namespace RingoUnity.Search.Dev
{
    internal class GetStageListSceneMain: MonoBehaviour
    {
        [SerializeField]
        private DIComponent _di;
        [SerializeField]
        private StageListMono _stageList;

        private void Awake()
        {
            _di.Initialize();
            _stageList.Initialize(OnSelect);
        }

        private void OnSelect(ExploreActionId action)
        {
            Debug.Log($"Selected: {action.Id}");
        }
    }
}