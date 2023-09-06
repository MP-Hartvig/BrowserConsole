using BrowserConsole.Gui;

GuiMenuLoop gui = new GuiMenuLoop();
HttpClient client = new HttpClient();

gui.MenuLoop(client);


//bool menuBool = true;

//Console.WriteLine("Paste an api url and press enter twice to see the content");

//while (menuBool)
//{
//    string input = Console.ReadLine() ?? "";

//    if (input.Length > 5)
//    {
//        if (Console.ReadKey().Key == ConsoleKey.Enter)
//        {
//            GetHtmlFromUrl(input);
//        }
//    }
//}

//async string GetHtmlFromUrl(string url)
//{
//    try
//    {
//        using HttpResponseMessage response = await client.GetAsync(url);
//        response.EnsureSuccessStatusCode();
//        string responseBody = await response.Content.ReadAsStringAsync();
//        string result = Regex.Replace(responseBody, @"<[^>]*>", string.Empty);
//        return result;
//    }
//    catch (InvalidOperationException e)
//    {
//        Console.WriteLine("\nException Caught!");
//        Console.WriteLine("Message :{0} ", e.Message);
//    }
//    catch (HttpRequestException e)
//    {
//        Console.WriteLine("\nException Caught!");
//        Console.WriteLine("Message :{0} ", e.Message);
//    }
//    catch (TaskCanceledException e)
//    {
//        Console.WriteLine("\nException Caught!");
//        Console.WriteLine("Message :{0} ", e.Message);
//    }
//    catch (UriFormatException e)
//    {
//        Console.WriteLine("\nException Caught!");
//        Console.WriteLine("Message :{0} ", e.Message);
//    }
//}