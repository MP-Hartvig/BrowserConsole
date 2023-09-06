namespace BrowserConsole.Gui
{
    internal class ExceptionPrinter
    {
        public void PrintExceptions(string message)
        {
            Console.WriteLine("\nException Caught!\n");
            Console.WriteLine("Message: \n{0}", message);
        }
    }
}
