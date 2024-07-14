
namespace SwiftSendLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, bool formatOutput = true, HttpsAction action = HttpsAction.GET);
        bool IsValidUrl(string url);
    }
}