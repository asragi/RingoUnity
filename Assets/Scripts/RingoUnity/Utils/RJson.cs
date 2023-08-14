using RLib.Utils;
using UnityEngine;

namespace RingoUnity.Utils
{
    public class RJson : IRJson
    {
        public T FromJson<T>(string json) => JsonUtility.FromJson<T>(json);
        public string ToJson(object o) => JsonUtility.ToJson(o);
    }
}
