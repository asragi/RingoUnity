namespace RLib.Utils
{
    public interface IRJson
    {
        string ToJson(object o);
        T FromJson<T>(string text);
    }
}
