using BrowserConsole.Gui;
using BrowserConsole.Interfaces;
using System.Text.RegularExpressions;

namespace BrowserConsole
{
    internal class RegexReplacer : IRegexReplacer
    {
        ExceptionPrinter ep = new ExceptionPrinter();

        public string RemoveHtmlTags(string responseBody)
        {
            string result = "";

            try
            {
                result = Regex.Replace(responseBody, @"<[^>]*>", string.Empty);
                return result;
            }
            catch (Exception e)
            {
                ep.PrintExceptions(e);
                return result;
            }
        }
    }
}
