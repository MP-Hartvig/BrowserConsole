using BrowserConsole.Interfaces;
using System.Text.RegularExpressions;

namespace BrowserConsole
{
    internal class RegexReplacer : IRegexReplacer
    {
        public string RemoveHtmlTags(string responseBody)
        {
            string result = "";

            try
            {
                result = Regex.Replace(responseBody, @"<[^>]*>", string.Empty);
                return result;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return result;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return result;
            }
            catch (RegexMatchTimeoutException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return result;
            }
        }
    }
}
