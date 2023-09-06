using BrowserConsole.Gui;
using BrowserConsole.Interfaces;

namespace BrowserConsole
{
    internal class ResponseMessage : IResponseMessage
    {
        ExceptionPrinter ep = new ExceptionPrinter();

        public async Task<HttpResponseMessage> GetHttpResponse(HttpClient client, string inputUrl)
        {
            HttpResponseMessage emptyResponse = new HttpResponseMessage();

            try
            {
                var response = await client.GetAsync(inputUrl);
                response.EnsureSuccessStatusCode();
                return response;
            }
            catch (InvalidOperationException e)
            {
                ep.PrintExceptions(e.Message);
                return emptyResponse;
            }
            catch (HttpRequestException e)
            {
                ep.PrintExceptions(e.Message);
                return emptyResponse;
            }
            catch (TaskCanceledException e)
            {
                ep.PrintExceptions(e.Message);
                return emptyResponse;
            }
            catch (UriFormatException e)
            {
                ep.PrintExceptions(e.Message);
                return emptyResponse;
            }
        }

        public async Task<string> GetHttpResponseBody(HttpResponseMessage response)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody ?? "";
        }
    }
}
