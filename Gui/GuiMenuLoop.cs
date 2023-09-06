namespace BrowserConsole.Gui
{
    internal class GuiMenuLoop
    {
        ResponseMessage rm = new ResponseMessage();
        RegexReplacer rr = new RegexReplacer();

        public async void MenuLoop(HttpClient client)
        {
            bool menuBool = true;

            Console.WriteLine("Paste an api url and press enter twice to see the content");

            while (menuBool)
            {
                string input = Console.ReadLine() ?? "";

                if (input.Length > 5)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        var response = await rm.GetHttpResponse(client, input);
                        var responseBody = await rm.GetHttpResponseBody(response);
                        await Console.Out.WriteLineAsync(rr.RemoveHtmlTags(responseBody));
                    }
                }
            }
        }
    }
}
