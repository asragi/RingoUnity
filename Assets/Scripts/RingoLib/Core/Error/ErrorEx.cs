namespace RingoLib.Core.Error {
    public static class ErrorEx
    {
        public static bool IsError(this IRError err)
            => err is not NoError;
    }
}
