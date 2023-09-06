namespace BrowserConsole.Interfaces
{
    internal interface IResponseMessage
    {
        public Task<HttpResponseMessage> GetHttpResponse(HttpClient client, string inputUrl);

        public Task<string> GetHttpResponseBody(HttpResponseMessage response);
    }
}
